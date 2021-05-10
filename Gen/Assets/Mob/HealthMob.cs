using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMob : MonoBehaviour
{
    
    public int health;
    public int maxHealth;
    public GameObject Player;

    private void Start()
    {
        StartCoroutine("addHealth");
    }
    IEnumerator addHealth()
    {
        while (true)
        {
            addHt();
            yield return new WaitForSeconds(1F);
        }
    }
    private void addHt()
    {
        if (health < maxHealth)
        {
            health++;
        }
    }
    private void FixedUpdate()
    {
        if (health <= 0)
        {
            Debug.Log("<0!");
            Destroy(Player);
        }
    }
    
    public void TakeHit(int damage)
    {
        health -= damage;
    }
}
