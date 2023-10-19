using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    //
    [SerializeField] public WheelCollider frontRightWheel;
    [SerializeField] public WheelCollider frontLeftWheel;
    [SerializeField] public WheelCollider backRightWheel;
    [SerializeField] public WheelCollider backLeftWheel;

    //
    [SerializeField] public Transform transformfrontRightWheel;
    [SerializeField] public Transform transformfrontLeftWheel;
    [SerializeField] public Transform transformbackRightWheel;
    [SerializeField] public Transform transformbackLeftWheel;
    //
    [Tooltip("")]
    public float maxTurnAngle= 15f;
    [Tooltip("")]
    public float aceleration = 10f;
    [Tooltip("")]
    public float breakingForce = 100f;
    //
    private float currentAceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;
    private void FixedUpdate()
    {
        if (GameManager.instanceGameManager.currentGameState == GameState.inGame)
        {
            //Obtain acceleration of the vertical axis by pressing the w and s keys forward or backward.
            //currentAceleration = aceleration * Input.GetAxis("Vertical");
            currentAceleration = aceleration * (Input.GetAxis("Vertical"));

            //press space to give current breakingforce a value
            if (Input.GetKey(KeyCode.Space))
                useBreakForce();
            else
                currentBreakForce = 0f;

            //apply the acceleration to the front wheels
            frontLeftWheel.motorTorque = currentAceleration;
            frontRightWheel.motorTorque = currentAceleration;

            //aply breaking force to all wheels
            frontLeftWheel.brakeTorque = currentBreakForce;
            frontRightWheel.brakeTorque = currentBreakForce;
            backLeftWheel.brakeTorque = currentBreakForce;
            backRightWheel.brakeTorque = currentBreakForce;

            //take care of the steering
            currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
            frontLeftWheel.steerAngle = currentTurnAngle;
            frontRightWheel.steerAngle = currentTurnAngle;

            //update wheel position in mesh and objects
            updateWheel(frontLeftWheel, transformfrontLeftWheel);
            updateWheel(frontRightWheel, transformfrontRightWheel);
            updateWheel(backLeftWheel, transformbackLeftWheel);
            updateWheel(backRightWheel, transformbackRightWheel);
        }
    }
    public void useBreakForce()
    {
        //aply breaking force to all wheels
        currentBreakForce = breakingForce;
        print("brake force");
    }
    private void updateWheel(WheelCollider wheelCollider, Transform objectWheelTransform)
    {
        //get wheel collider state
        Vector3 position;
        Quaternion rotation;

        //Gets the world space pose of the wheel accounting for ground contact, suspension limits, steer angle, and rotation angle (angles in degrees)
        wheelCollider.GetWorldPose(out position, out rotation);

        //set wheel transform state
        objectWheelTransform.position = position;
        objectWheelTransform.rotation = rotation;
    }
}
