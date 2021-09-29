using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_AttackController : MonoBehaviour
{
    public GameObject p_Shot;
    public GameObject Shot;
    GameObject myShot;
    // Start is called before the first frame update
    void Start()
    {
        myShot = p_Shot;
    }
    public void Shoot()
    {
        Instantiate<GameObject>(Shot,myShot.transform.position,Quaternion.identity);
    }
}
