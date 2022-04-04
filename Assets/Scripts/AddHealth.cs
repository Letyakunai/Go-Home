using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
   public int HealthAdd;
   public PlayerHP Playerhealth;

    public void Adding()
    {
        Playerhealth.health += 1;
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Adding();
        }
    }
}