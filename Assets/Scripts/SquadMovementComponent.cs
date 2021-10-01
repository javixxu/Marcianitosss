using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadMovementComponent : MonoBehaviour
{
    private int _initialDirection;
    private float _verticalSpeed=0.001f;
    private float _horizontalSpeed=1.5f;
    private float _frequency=1.5f;
    public float _amplitude=1.5f;//diametro del movimiento
     float y;//para comprobar la altura establecida para destruir el objeto
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //el volar x esta entre -1 y 1 y se actualiza de manera constante del el tiempo real,
        //si le multiplicamos por frequency aceleramoso frenamos y la amplitud del movimiento
        float x = Mathf.Cos(Time.time * _frequency) * _amplitude;

         y = transform.position.y;

        //el transform.position es par que se vea con el fondo este delante
        transform.position = new Vector3(x,y-_verticalSpeed,0);
    }
    public float Altura() { return y; }
}
