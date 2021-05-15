using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMob : MonoBehaviour
{
    public Transform player;
    private bool Time = true;
    private int a = 50;
    public GameObject AtackArea;
    private bool StartTime = false;
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) >= 1.5)
        {
            if (Time)
            {
                AtackArea.SetActive(true);
                Time = false;
                StartTime = true;
            }
            else
            {
                AtackArea.SetActive(false);
            }
        }
        if (StartTime)
        {
            a--;
            if (a == 0)
            {
                StartTime = false;
                Time = true;
                a=50;
            }
        }
    }
}
