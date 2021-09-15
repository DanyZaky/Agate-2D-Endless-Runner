using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIGameoverController : MonoBehaviour
{
    public GameObject pauseButton, pauseMenu, panelScore;
    
    public void TekanButtonRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseButton()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        panelScore.SetActive(false);
        Time.timeScale = 0;
        
    }

    public void UnpauseButton()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        panelScore.SetActive(true);
    }

    public void tekanMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
        
}
