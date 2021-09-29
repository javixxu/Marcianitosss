using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementComponent : MonoBehaviour
{
    Rigidbody2D rb;
    ShipInputComponent ship;
    Vector3 dir;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ship = GetComponent<ShipInputComponent>();
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(dir*velocity*Time.deltaTime);
    }
   public void SetDirection(Vector3 movemntDirection)
   {
        dir = movemntDirection;
        dir.z = 0;
   }
}
