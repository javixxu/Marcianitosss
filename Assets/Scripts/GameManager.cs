using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isGameRunning;
    UIManager _uiManager;

    [SerializeField]
     GameObject[] _squads;
    [SerializeField]
     GameObject player;
    //PUNTOS DEL JUGADOR
    int Score=0;
    //GENERACION DE ENEMIGOSS
    public float tiempoRespawn=15;
    private float _timer;

    static private GameManager _instance;
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
    private void Start()
    {
        //variable en la que se inicia el juego
        _isGameRunning = true;
        //PODER CONECTAR LA UI CON EL GAMEMANAGER
         _uiManager = GetComponent<UIManager>();
        //TIEMPO DE RESPAWN
        _timer = tiempoRespawn;
    }
    //Instanciar el gamemanager en otras instancias
    static public GameManager Instance()
    {
        return _instance;
    }
    
    // Update is called once per frame
    void Update()
    {        
        _timer -= Time.deltaTime;

        if (_isGameRunning&&(int)_timer < 0) {
            int aleatorio= Random.Range(0, _squads.Length );
            Instantiate<GameObject>(_squads[aleatorio],transform.position,Quaternion.identity);
            _timer = tiempoRespawn;
        }              
    }
    public void OnEnemyDies(int scoreToAdd) {
       Score += scoreToAdd;
       Debug.Log(Score);
    }
    public void OnEnemyReachesBottomline()
    {       
        player.SetActive(false);
        MGameOver();
        Debug.Log("LOS ENEMIGOS HAN LLEGADO A LA DEATHZONE");
    }
    public void OnPlayerDies()
    {
        player.SetActive(false);
        MGameOver();
        Debug.Log("EL JUGADOR A MUERTO");
    }
    private void MGameOver()
    {
        _isGameRunning = false;
        _uiManager.GameOver(Score);
    }
    
}
