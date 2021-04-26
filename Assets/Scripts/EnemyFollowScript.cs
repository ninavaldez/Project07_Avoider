//Full Name: Nina Valdez
//Student ID: 2324247
//Chapman email: divaldez @chapman.edu
//Course number and section: 236-03
//Assignment Number: 07 - Avoider
//This is my own work, and I did not cheat on this assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Part of Q2: Detecting and chasing Enemies with distance
// restarting game when collision occurs (when player dies)
public class EnemyFollowScript : MonoBehaviour
{

    public float speed;
    private Transform target;
    public float distance;

    ////Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) <= distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
