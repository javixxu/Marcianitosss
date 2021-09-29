using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeController : MonoBehaviour
{

    public float liveBullet = 2;
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, liveBullet);
    }
}
