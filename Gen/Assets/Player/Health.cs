using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    
    public int health;
    public Text healthT;
    public int maxHealth;
    public GameObject Player;
    public string CollisionTag;

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
        healthT.text = "Health: " + health + "/" + maxHealth;
        if (health <= 0)
        {
            Destroy(Player);
        }
    }
    
    public void TakeHit(int damage)
    {
        health -= damage;
    }
}
