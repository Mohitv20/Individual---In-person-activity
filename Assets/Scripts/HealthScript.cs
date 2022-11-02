using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            {
                HealthManager.instance.ChangeHealth(2); 
                Destroy(gameObject);
            }
        }
    }
}
