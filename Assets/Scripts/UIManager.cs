using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public GameObject gameOver,Score,victoria;
   public Text scoreText;
   public string nombreScena="GAME1";
    private void Start()
    {
        Score.SetActive(false);
        gameOver.SetActive(false);
    }
    public void GameOver(int points)
    {
        gameOver.SetActive(true);
        scoreText.text = points.ToString();
        Score.SetActive(true);
    }
    public void ChageScene()
    {
       SceneManager.LoadScene(nombreScena);
    }
    public void Victoria()
    {
        victoria.SetActive(true);
        // Invoke("ChageScene",5);
        Time.timeScale = 0;
       
    }
}
