using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarMob : MonoBehaviour
{
    public Camera camera_;
    public Slider slider;
    private GameObject obj;
    void Start()
    {
        RaycastHit hit;
        Ray ray = camera_.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            obj = objectHit.gameObject;
            SetMaxHealt(obj.GetComponent<Health>().maxHealth);
        }       
    }
    private void Update()
    {
        SetHealth(obj.GetComponent<Health>().health);
    }

    public void SetMaxHealt(int Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
    }
    public void SetHealth(int Health)
    {
        slider.value = Health;
    }
}