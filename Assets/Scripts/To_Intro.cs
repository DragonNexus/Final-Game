using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Intro : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Scenes/Scene");
        Debug.Log("Game Started");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    
}