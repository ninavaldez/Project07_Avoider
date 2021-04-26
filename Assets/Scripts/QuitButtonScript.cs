//Full Name: Nina Valdez
//Student ID: 2324247
//Chapman email: divaldez @chapman.edu
//Course number and section: 236-03
//Assignment Number: 07 - Avoider
//This is my own work, and I did not cheat on this assignment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Part of Q5: Quit button part of Menu and in game
public class QuitButtonScript : MonoBehaviour
{
    public GameObject QuitButton;


    public void Quit()
    {
        Debug.Log("Game is Quitting... ");
        Application.Quit();
        Debug.Log("Game Quit - Goodbye! ");
    }
}
