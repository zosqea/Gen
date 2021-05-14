using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject AtackArea;
    public bool Time = true;
    public int a = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time)
        {
            AtackArea.SetActive(true);
            Time = false;
            StartCoroutine("AtackTime");
        }
        else
        {
            AtackArea.SetActive(false);
        }
        if (Time == false)
        {
            
        }
    }
    IEnumerator AtackTime()
    {
        while (true)
        {
            a++;
            ATime();
            yield return new WaitForSeconds(1F);
        }
    }
    private void ATime()
    {
        if (a==2)
        {
            Time = true;
            StopCoroutine("AtackTime");
            a = 0;
        }
    }
}
