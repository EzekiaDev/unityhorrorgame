using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;

public class menu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManagment.LoadScene(SceneManagment.GetActiveScene().buildIndex + 1);
    }
}
