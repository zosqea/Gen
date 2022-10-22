using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image health;
    public Health playerHealt;

    private void Update()
    {
        SetHealth(playerHealt.health,playerHealt.maxHealth);
    }
    public void SetHealth(float Health, float maxHealth)
    {
        health.fillAmount = Health / maxHealth;
    }
}