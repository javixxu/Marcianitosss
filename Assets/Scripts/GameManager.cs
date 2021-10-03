using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isGameRunning;    
    static private GameManager _instance;
    static public GameManager Instance;
    private GameObject[] _squads;
    int Score=0;
    float timer;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if ((int)timer / 5 < 0) {
            Debug.Log("Niggers");
           
        }
        
        Debug.Log(timer);
    }
    public void OnEnemyDies(int scoreToAdd) {
       Score += scoreToAdd;    
    }
}
