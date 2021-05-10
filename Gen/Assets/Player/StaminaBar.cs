using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
    public Stamina playerStamina;

    private void Start()
    {
        SetMaxHealt(playerStamina.maxStamina);
    }
    private void Update()
    {
        SetHealth(playerStamina.stamina);
    }

    public void SetMaxHealt(int Stamina)
    {
        slider.maxValue = Stamina;
        slider.value = Stamina;
    }
    public void SetHealth(int Stamina)
    {
        slider.value = Stamina;
    }
}
