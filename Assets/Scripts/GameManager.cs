using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverCanvas;

    void Start()
    {
       Time.timeScale = 1; 
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Replay()
    {
        // Debug.Log("Replay");
        SceneManager.LoadScene(0);
        // gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
