using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public void Lecturebtn()
    {
        // SceneManager.LoadScene(1);
        Debug.Log("Lecture");
    }
    public void Activitiesbtn()
    {
        //SceneManager.LoadScene(2);
        Debug.Log("activity");

    }
    public void Quitbtn()
    {
        Debug.Log("quit");
        Application.Quit();
        
    }
}
