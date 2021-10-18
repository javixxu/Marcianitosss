using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovementController : MonoBehaviour
{
    Rigidbody2D rb;
    public float shotSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, shotSpeed) * shotSpeed;
    }
    //NO VIENE EN LA PRACTICA PA QUE QUEDE MEJOR
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}



