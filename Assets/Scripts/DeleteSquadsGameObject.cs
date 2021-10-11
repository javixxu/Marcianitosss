using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSquadsGameObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SquadMovementComponent>())
        {
            Debug.Log("fsdsd");
            Destroy(this.gameObject);
        }
    }
}
