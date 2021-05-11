using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject AtackArea;
    public GameObject mob;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            AtackArea.SetActive(true);
        }
        else
        {
            //AtackArea.SetActive(false);
        }
        if (Input.GetKey(KeyCode.B))
        {
            mob.GetComponent<Health>().TakeHit(1);
        }
    }
}
