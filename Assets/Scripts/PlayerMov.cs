//Full Name: Nina Valdez
//Student ID: 2324247
//Chapman email: divaldez @chapman.edu
//Course number and section: 236-03
//Assignment Number: 07 - Avoider
//This is my own work, and I did not cheat on this assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour

{
    public Vector2 Position;

    public float Speed = 4f;
    private float firstClick;
    private float timeBetween;

    private bool coroutineAllowed;
    private int clicksCounter;

    private void Start()
    {
        clicksCounter = 0;
        firstClick = 0f;
        timeBetween = 0.2f;

        coroutineAllowed = true;
    }

    private void Update()
    {

        // mouse position
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            clicksCounter++;
            Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (clicksCounter == 1 && coroutineAllowed)
        {
            Speed = 4;
            firstClick = Time.time;
            StartCoroutine(DoubleClick());
        }
    }

    // Q3: Player will have dash ability
    // double clicking/dash feature
    private IEnumerator DoubleClick()
    {
        coroutineAllowed = false;
        while (Time.time < firstClick + timeBetween)
        {
            if (clicksCounter == 2)
            {
                Speed = 8;
                yield return new WaitForSeconds(1.5f);

            }

            else
            {
                yield return new WaitForEndOfFrame();
            }

        }
        clicksCounter = 0;
        firstClick = 0f;
        coroutineAllowed = true;
    }


    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, Position, Time.deltaTime * Speed);
    }

}



