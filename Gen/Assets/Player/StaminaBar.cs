using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Image staminaFiller;
    public Stamina playerStamina;
    private void Update()
    {
        SetHealth(playerStamina.stamina,playerStamina.maxStamina);
    }
    public void SetHealth(float Stamina, float maxStamina)
    {
        staminaFiller.fillAmount = Stamina / maxStamina;
    }
}
