using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atack : MonoBehaviour
{
    public GameObject atackAreaObject;
    public GameObject attckBarObject;
    public Image attackTime;
    private bool Time = true;
    private int a = 50;
    private bool StartTime = false;
    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Mouse0) && gameObject.GetComponent<Stamina>().stamina >= 10)
        {
            if (Time)
            {
                gameObject.GetComponent<Stamina>().attackUnStamina();
                atackAreaObject.SetActive(true);
                Time = false;
                StartTime = true;
            }
        }
        else
        {
            atackAreaObject.SetActive(false);
        }
        if (StartTime)
        {
            a--;
            attckBarObject.SetActive(true);
            if (a == 0)
            {
                StartTime = false;
                Time = true;
                a=50;
            }
        }
        else
        {
            attckBarObject.SetActive(false);
        }
    }
    private void Update()
    {
        SetHealth(a);
    }
    public void SetHealth(float AtackTime)
    {
        
        attackTime.fillAmount = AtackTime/50f;
    }
}