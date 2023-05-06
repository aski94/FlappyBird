using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public GameObject UI;
    public GameObject scoreUI;

    void Start()
    {
        Time.timeScale = 1;
    }
  
    public void Death()
    {
        Time.timeScale = 0;
        UI.SetActive(true);
        scoreUI.SetActive(false);
        
    }

    public void GameRestart()
    {
       // Debug.Log("click");
        SceneManager.LoadScene("PreGame");
        Time.timeScale = 1;
        ScoreCount.score = 0;
    }

    public void ExitGame()
    {
        Debug.Log("ExitedGame");
        Application.Quit();
    }
}
