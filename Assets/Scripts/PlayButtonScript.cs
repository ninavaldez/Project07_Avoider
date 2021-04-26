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

// Part of Q5: Play button part of Menu
public class PlayButtonScript : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Playing Game");
    }
}
