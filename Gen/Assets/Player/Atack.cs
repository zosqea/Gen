using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject AtackArea;
    //public bool Time = true;
    //public int a = 2;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)/* && Time*/)
        {
            AtackArea.SetActive(true);
            //Time = false;
            //StartCoroutine("AtackTime");
        }
        else
        {
            AtackArea.SetActive(false);
        }
        /*if (Time == false)
        {
            
        }
        if (a==0)
        {
            Time = true;
            StopAllCoroutines();
            a = 2;
        }*/
    }
    /*IEnumerator AtackTime()
    {
        while (true)
        {
            a-=1;
            yield return new WaitForSeconds(1F);
        }
    }*/
}