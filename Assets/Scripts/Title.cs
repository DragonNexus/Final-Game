using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
        Debug.Log("Game Started");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    
}