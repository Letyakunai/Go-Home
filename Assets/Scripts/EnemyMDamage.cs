using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMDamage : MonoBehaviour
{
    public PlayerHP Playerhealth;
    public LevelLoader LeveltoLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Playerhealth.health -= 1;
        }

        if (Playerhealth.health <= 0)
        {
            //DestroySelf(collision.gameObject);
            LeveltoLoad.LoadLevel();
        }
    }

    /*private void DestroySelf(GameObject collidedObject)
    {
        Destroy(collidedObject);
        Destroy(this.gameObject);
    }*/
}
