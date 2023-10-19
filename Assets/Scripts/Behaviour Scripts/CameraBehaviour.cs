using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject playerTarget = null;
    public GameObject cameraTarget = null;
    public float speed = 1.5f;

    void Start()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        cameraTarget = playerTarget.transform.Find("Cam_Pos").gameObject;
    }


    void FixedUpdate()
    {
        follow();
    }

    public void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, cameraTarget.transform.position,Time.deltaTime * speed);
        gameObject.transform.LookAt(playerTarget.gameObject.transform.position);
    }
}
