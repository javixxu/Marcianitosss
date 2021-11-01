using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadMovementComponent : MonoBehaviour
{
    #region References//para intentar acceder a un script o GameObject
    #endregion
    #region Properties//variables que solo necesita el programador(privadas y tal)
    #endregion
    #region Parameters//variables publicas que le interesaria cambiar al diseñador

    #endregion
    #region Methods//metodos
    #endregion
    private int _initialDirection;
    private float _verticalSpeed=0.004f;
    private float _horizontalSpeed=1.5f;
    private float _frequency=1.5f;
    //pregunbtar si lo puedo dejar publico
    public float _amplitude=1.5f;//diametro del movimiento
     float _y;//para comprobar la altura establecida para destruir el objeto
    // Start is called before the first frame update
    void Start()
    {
        _initialDirection = Random.Range(0, 2);
        if (_initialDirection == 0) _initialDirection = -1;
    }

    // Update is called once per frame
    void Update()
    {
        //si quierpo destruirlo pq ya no queda nada ,ademas de que no hay ningun enemigo pq si no hubiese saltado que el jugador ha perdido
        if (transform.position.y <= -5) { Destroy(this.gameObject); }
        //el volar x esta entre -1 y 1 y se actualiza de manera constante del el tiempo real,
        //si le multiplicamos por frequency aceleramoso frenamos y la amplitud del movimiento
        float x = Mathf.Cos(Time.time * _frequency) * _amplitude*_initialDirection;

         _y = transform.position.y;

        //el transform.position es par que se vea con el fondo este delante
        transform.position = new Vector3(x,_y-_verticalSpeed,0);
    }
    public float Altura() { return _y; }
    public void Destruir() { Destroy(this.gameObject); }
    
}
