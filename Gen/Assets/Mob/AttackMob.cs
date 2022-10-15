using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMob : MonoBehaviour
{
    public GameObject attackArea;
    private bool cD = false;
    public void Start()
    {
        StartCoroutine(attack());
    }
    public IEnumerator attack()
    {
        while (true)
        {
            if (!cD)
            {
                attackArea.SetActive(true);
                cD = true;
            }
            else
            {
                attackArea.SetActive(false);
                cD = false;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
