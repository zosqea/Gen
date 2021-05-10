using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;
    public GameObject player;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = player.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }
}