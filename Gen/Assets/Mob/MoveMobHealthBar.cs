using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMobHealthBar : MonoBehaviour
{
    public Transform player;
    public Transform HealthBarMob;
    public float speedRotation;
    void Update()
    {
        Vector3 Rotation = player.position - HealthBarMob.position;
        HealthBarMob.rotation = Quaternion.Slerp(HealthBarMob.rotation, Quaternion.LookRotation(Rotation), speedRotation * Time.deltaTime);
    }
}