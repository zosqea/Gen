using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int damage = 10;
    public string collisionTag;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            collision.gameObject.GetComponent<Health>().TakeHit(damage);
            collision.gameObject.GetComponent<BattleMode>().startBattleMode();
            gameObject.GetComponentInParent<BattleMode>().startBattleMode();
        }
    }
}