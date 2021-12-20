using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{

    public void Back1()
    {
        SceneManager.LoadScene("Scenes/Title Screen");
        Debug.Log("Game Started");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    
}