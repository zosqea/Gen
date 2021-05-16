using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSlider : MonoBehaviour
{
    public Slider sr;
    public Text textSr;
    public int minV;
    public int maxV;
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textSr.text = Convert.ToInt32(sr.value) + "/" + maxV;
        sr.minValue = minV;
        sr.maxValue = maxV;
        player.GetComponent<MouseLook>().AddSens(sr.value);
    }
}
