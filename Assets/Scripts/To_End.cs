using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_End : MonoBehaviour
{

    public void End1()
    {
        SceneManager.LoadScene("Scenes/End1");
        Debug.Log("Game Started");
    }
    
    public void End2()
    {
        SceneManager.LoadScene("Scenes/End2");
        Debug.Log("Game Started");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    
}