using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void gotoscene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
}

