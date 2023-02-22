using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject text;
  
    // Start is called before the first frame update
    public void Start()
    {
        
        gameOverPanel.SetActive(false);
        Time.timeScale = 0f;
    }
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            startgame();
            
        }

    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }
 public void RESTART()
    {
        SceneManager.LoadScene("begin");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void pause()
    {
        Time.timeScale = 0f;
    }
    public void startgame()
    {
        text.SetActive(false);
        Time.timeScale = 1f;
    }
}
