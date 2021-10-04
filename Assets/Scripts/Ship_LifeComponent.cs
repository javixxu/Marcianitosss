using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_LifeComponent : MonoBehaviour
{
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy_LifeComponent>()) { Destroy(this.gameObject);gameManager.OnPlayerDies(); }
    }
}
