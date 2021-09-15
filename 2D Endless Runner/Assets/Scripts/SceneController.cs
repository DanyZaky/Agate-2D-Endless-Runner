using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void tekanPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void tekanQuit()
    {
        Application.Quit();
    }
}
