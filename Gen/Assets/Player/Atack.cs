using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atack : MonoBehaviour
{
    public GameObject AtackArea;
    public GameObject TAttack;
    public Slider slider;
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
                gameObject.GetComponent<BattleMode>().startBattleMode();
                AtackArea.SetActive(true);
                Time = false;
                StartTime = true;
            }
        }
        else
        {
            AtackArea.SetActive(false);
        }
        if (StartTime)
        {
            a--;
            TAttack.SetActive(true);
            if (a == 0)
            {
                StartTime = false;
                Time = true;
                a=50;
            }
        }
        else
        {
            TAttack.SetActive(false);
        }
    }
    private void Start()
    {
        SetMaxHealt(50);
    }
    private void Update()
    {
        SetHealth(a);
    }

    public void SetMaxHealt(int AtackTime)
    {
        slider.maxValue = AtackTime;
        slider.value = AtackTime;
    }
    public void SetHealth(int AtackTime)
    {
        slider.value = AtackTime;
    }
}