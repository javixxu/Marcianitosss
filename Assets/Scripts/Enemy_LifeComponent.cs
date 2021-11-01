using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_LifeComponent : MonoBehaviour
{
    #region References
    GameManager _myGameManager;
    WorldVerticalDeadlineComponent _deadlineComponent;
    #endregion
    #region Properties
    #endregion
    #region Parameters
    public int livesEnemy = 2;
    public int points = 100;
    #endregion
    #region Methods
    public void Damageable()
    {
        Destroy(this.gameObject);
        _myGameManager.OnEnemyDies(points);
    }
    #endregion  
    private void Start()
    {
        _myGameManager = GameManager.Instance();       
    }
    private void OnTriggerEnter2D(Collider2D collision)  
    {
        //NO VIENE EN LA PRACTICA , PERO ES PARA Q SOLO LOS ENEMIGOS PIUEDAN DESTRUIRSE CON BALAS
        if (collision.gameObject.GetComponent<ShotMovementController>())
        {           
            livesEnemy--;
            if (livesEnemy <= 0)
            {
                Damageable();                
            }
        }
    }
}
