using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    
    public int stamina;
    public Text staminaT;
    public int maxStamina;
    public GameObject player;
    public bool trafficU = false;
    private void Start()
    {
        StartCoroutine("unStamina");
        StartCoroutine("addStamina");
    }
    IEnumerator unStamina()
    {
        while (true)
        {
            unSt();
            yield return new WaitForSeconds(0.2F);
        }
    }
    IEnumerator addStamina()
    {
        while (true)
        {
            addSt();
            yield return new WaitForSeconds(1F);
        }
    }
    private void unSt()
    {
        if (trafficU)
        {
            stamina--;
        }
    }
    private void addSt()
    {
        if (!trafficU)
        {
            if (stamina < maxStamina)
            {
                stamina++;
            }
        }
    }
    private void FixedUpdate()
    {
        staminaT.text = "Stamina: " + stamina + "/" + maxStamina;
        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            PlayerMovement Speed = player.GetComponent<PlayerMovement>();
            Speed.SpeedU(2);
            trafficU = true;
        }
        else
        {
            PlayerMovement Speed = player.GetComponent<PlayerMovement>();
            Speed.SpeedU(1);
            trafficU = false;
        }
    }
}
