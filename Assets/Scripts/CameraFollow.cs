//Full Name: Nina Valdez
//Student ID: 2324247
//Chapman email: divaldez @chapman.edu
//Course number and section: 236-03
//Assignment Number: 07 - Avoider
//This is my own work, and I did not cheat on this assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

// Q1: Top Down Perspective 
{

    public Transform followTransform;
    private Vector3 smoothPos;
    private float smoothSpeed = 0.5f;

    public GameObject cameraLeftBoarder;
    public GameObject cameraRightBoarder;

    private float cameraHalfWidth;

    // Start is called before the first frame update
    void Start()
    {
        cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float boarderLeft = cameraLeftBoarder.transform.position.x + cameraHalfWidth;
        float boarderRight = cameraRightBoarder.transform.position.x - cameraHalfWidth;

        smoothPos = Vector3.Lerp(this.transform.position,
            new Vector3(Mathf.Clamp(followTransform.position.x, boarderLeft, boarderRight),
            this.transform.position.y,
            this.transform.position.z), smoothSpeed);

        this.transform.position = smoothPos;

    }
}
