using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject playerTarget = null;
    //not the camera - is the position is the position where you want the camera to be tracked
    public GameObject cameraTarget = null;
    public float speed = 1.5f;

    void Start()
    {
        //serch the player and the camera pos in car
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        cameraTarget = playerTarget.transform.Find("Cam_Pos").gameObject;
    }


    void FixedUpdate()
    {
        follow();
    }

    public void follow()
    {
        //interpolation between the player and camera pos obj whit intervale inseconds
        gameObject.transform.position = Vector3.Lerp(transform.position, cameraTarget.transform.position,Time.deltaTime * speed);
        gameObject.transform.LookAt(playerTarget.gameObject.transform.position);
    }
}
