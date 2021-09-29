using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputComponent : MonoBehaviour
{

    float x, y;
    Vector3 dir;
    ShipMovementComponent direc;
    Ship_AttackController AttackController;
    private void Start()
    {
        direc = GetComponent<ShipMovementComponent>();
        AttackController = GetComponent<Ship_AttackController>();
    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        SetMovementDirection();
      
        if (Input.GetKeyDown("space")) { AttackController.Shoot(); }
        
    }
    void SetMovementDirection()
    {
        dir = new Vector3(x, y,-9);
        direc.SetDirection(dir);
    }
}
