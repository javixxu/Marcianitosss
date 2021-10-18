using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameManager _myGameManager;
   public GameObject gameOver,Score,victoria;
   public Text scoreText;
   public string nombreScena="GAME1";
    private void Start()
    {
        _myGameManager = GameManager.Instance();
        
    }
    public void GameOver(int points)
    {
        gameOver.SetActive(true);
        showScore(points);
        Invoke("ChageScene", 5);
     
    }
    public void ChageScene()
    {
        //_myGameManager.EmpiezaJuego();    
        SceneManager.LoadScene(nombreScena);
       
    }
    public void Victoria(int points)
    {
        victoria.SetActive(true);
        showScore(points);
        Invoke("ChageScene",5);
        
    }
    void showScore(int points)
    {
        scoreText.text = points.ToString();
        Score.SetActive(true);
    }
    
}
