using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isGameRunning;    
    static private GameManager _instance;
    
    private GameObject[] _squads;
    int Score=0;
    float timer;
    void Awake()
    {

        if (_instance == null)
        {
            //Asegurar que solo exista una instancia del Game Manager
            _instance = this;
            //Evita que el gameManager se destruya al cambiar de escena
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Si hay mas de una instancia, se destruye
            Destroy(this.gameObject);
        }
    }
    //Instanciar el gamemanager en otras instancias
    static public GameManager Instance()
    {
        return _instance;
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if ((int)timer / 5 < 0) {
            Debug.Log("Niggers");
           
        }
        
       // Debug.Log(timer);
    }
    public void OnEnemyDies(int scoreToAdd) {
       Score += scoreToAdd;
        Debug.Log(Score);
    }
}
