using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject AtackArea;
    public string mobTag;
    public int damage;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == mobTag)
        {
            Health health = col.gameObject.GetComponent<Health>();
            health.TakeHit(damage);
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            AtackArea.SetActive(true);
        }
        else
        {
            AtackArea.SetActive(false);
        }
    }
}
