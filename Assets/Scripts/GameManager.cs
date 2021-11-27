using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region referencies
    UIManager _uiManager;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject[] _squads;  
    #endregion
    #region properties
    [SerializeField]
    int _winPoints;
    private bool _isGameRunning;
    //PUNTOS DEL JUGADOR
    int _score = 0;
    private float _timer;
    #endregion
    #region parameters
    //GENERACION DE ENEMIGOSS
    public float tiempoRespawn = 15;
    #endregion
    #region methods
    static private GameManager _instance;
    //Instanciar el gamemanager en otras instancias
    static public GameManager Instance()
    {
        return _instance;
    }
    public void OnEnemyDies(int scoreToAdd)
    {
        _score += scoreToAdd;
        Debug.Log(_score);
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
        Debug.Log("EL JUGADOR HA MUERTO");
    }
    private void MGameOver()
    {
        _isGameRunning = false;

        _uiManager.GameOver(_score);
    }
    void Victoria()
    {
        _isGameRunning = false;

        _uiManager.Victoria(_score);
    }
    #endregion

    void Awake()
    {               
        if (_instance == null)
        {
            //Asegurar que solo exista una instancia del Game Manager
            _instance = this;
            //Evita que el gameManager se destruya al cambiar de escena
            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Si hay mas de una instancia, se destruye
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        //variable en la que se inicia el juego, 
        _isGameRunning = true;
              
        //PODER CONECTAR LA UI CON EL GAMEMANAGER
        _uiManager = GetComponent<UIManager>();
        //TIEMPO DE RESPAWN
        _timer = tiempoRespawn;
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
        if (_score >= _winPoints) Victoria();
       
    }
   
    //public void EmpiezaJuego() { _isGameRunning =!_isGameRunning;  }
   // void OnLevelWasLoaded(int level)
    //{
    //    if (level == 1)
    //        _isGameRunning = true;

    //}
    
}
