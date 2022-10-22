using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public Transform player;
    public Transform spawn;
    public int dist;
    public Transform mob;
    public float speedRotation;
    public float speedMove;
    void Start()
    {
        spawn.GetComponent<Renderer>().enabled = false;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < dist)
        {
            if (Vector3.Distance(transform.position, player.transform.position) > 2)
            {
                Vector3 Rotation = player.position - mob.position;
                mob.rotation = Quaternion.Slerp(mob.rotation, Quaternion.LookRotation(Rotation), speedRotation*Time.deltaTime);
                mob.transform.position += mob.forward*speedMove*Time.deltaTime;
                mob.transform.localPosition = new Vector3(transform.position.x,0.5f, transform.position.z);
                mob.transform.localRotation = new Quaternion(0f, transform.rotation.y,0f, transform.rotation.w);
                Debug.Log("Должен приближаться");
            }
            else
            {
                Debug.Log("Не до лжен приближаться");
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, spawn.transform.position) > 1)
            {
                Vector3 Rotation = spawn.position - mob.position;
                mob.rotation = Quaternion.Slerp(mob.rotation, Quaternion.LookRotation(Rotation), speedRotation*Time.deltaTime);
                mob.transform.position += mob.forward*speedMove*Time.deltaTime;
                mob.transform.localPosition = new Vector3(transform.position.x,0.5f, transform.position.z);
                mob.transform.localRotation = new Quaternion(0f, transform.rotation.y,0f, transform.rotation.w);
            }
        }
    }
}
