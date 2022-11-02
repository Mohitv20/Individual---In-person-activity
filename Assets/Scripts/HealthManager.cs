using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    int health = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public float pHealth = 100.0f;

    public void DealDamage(float a)
    {
        pHealth -= a;

        if (pHealth <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHealth(int h)
    {
        health += h;
        Debug.Log(health);
    }
}
