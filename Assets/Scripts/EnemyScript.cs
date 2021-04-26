//Full Name: Nina Valdez
//Student ID: 2324247
//Chapman email: divaldez @chapman.edu
//Course number and section: 236-03
//Assignment Number: 07 - Avoider
//This is my own work, and I did not cheat on this assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Part of Q2: Waypoints for Patrol
public class EnemyScript : MonoBehaviour
{
    public List<EnemyWaypointScript> Waypoints = new List<EnemyWaypointScript>();
    public float Speed = 1.0f;
    public int DestinationWaypoint = 1;


    private Vector3 Destination;
    private bool Forwards = true;


    public float speed;
    //private Transform target;
    public float distance;



    // Start is called before the first frame update
    void Start()
    {
        this.Destination = this.Waypoints[DestinationWaypoint].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        StopAllCoroutines();
        StartCoroutine(MoveTo());
    }

        IEnumerator MoveTo()
    {
        while ((transform.position - this.Destination).sqrMagnitude > 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                this.Destination, this.Speed * Time.deltaTime);
            yield return null;
        }


        if ((transform.position - this.Destination).sqrMagnitude <= 1f)
        {
            GetNextWaypoint();
        }

        void GetNextWaypoint()
        {
            if (this.Waypoints[DestinationWaypoint].IsEndpoint)
            {
                if (this.Forwards)
                    this.Forwards = false;
                else
                    this.Forwards = true;

            }

            if (this.Forwards)
                ++DestinationWaypoint;

            else
                --DestinationWaypoint;

            this.Destination = this.Waypoints[DestinationWaypoint].transform.position;
        }

    }
}