using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldVerticalDeadlineComponent : MonoBehaviour
{
    GameManager gameManager;
    SquadMovementComponent alturaDESTRUCT;
    public float alturaMAX;
    
    // Start is called before the first frame update
    void Start()
    {
        alturaDESTRUCT = GetComponentInParent<SquadMovementComponent>();
        gameManager = GameManager.Instance();
    }

    // Update is called once per frame
    void Update()
    {  
        if (alturaDESTRUCT.Altura() <= alturaMAX) { Destroy(this.gameObject);gameManager.OnEnemyReachesBottomline();alturaDESTRUCT.Destruir(); }
    }
    
}
