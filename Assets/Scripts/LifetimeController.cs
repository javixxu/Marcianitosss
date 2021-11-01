using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeController : MonoBehaviour
{
    #region References
    #endregion
    #region Properties
    #endregion
    #region Parameters
    public float liveBullet = 2;
    #endregion
    #region Methods
    #endregion    
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, liveBullet);
    }
}
