using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMDamage : MonoBehaviour
{
    public PlayerHP Playerhealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyHitbox")
        {
            Playerhealth.health -= 1;
        }

        if (Playerhealth.health <= 0)
        {
            DestroySelf(collision.gameObject);
        }
    }

    private void DestroySelf(GameObject collidedObject)
    {
        Destroy(collidedObject);
        Destroy(this.gameObject);
    }
}
