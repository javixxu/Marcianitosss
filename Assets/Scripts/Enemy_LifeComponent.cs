﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_LifeComponent : MonoBehaviour
{
   public int livesEnemy=2;
    private void OnCollisionEnter2D(Collision2D collision)
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
    public void Damageable()
    {
        Destroy(this.gameObject);
    }
}
