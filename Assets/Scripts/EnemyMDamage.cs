using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMDamage : MonoBehaviour
{
    public PlayerHP Playerhealth;
    public LevelLoader LeveltoLoad;
    //public Invulnerability Invul;
    [Header("Invun Time")]
    [SerializeField]
    private float invunT;
    private float interval;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerScore.ScoreValue += 100;
            //Invul.StartCoroutine(IFrame());

            //invunT += Time.deltaTime * 1;

            //if (invunT > interval)
            //{
            Playerhealth.health -= 1;
            //    invunT = 0.0f;
            //}
            
        }

    

        if (Playerhealth.health <= 0)
        {
            //DestroySelf(collision.gameObject
            LeveltoLoad.LoadLevel();
            Debug.Log("Ded.");
        }
    }

/*    private void DestroySelf(GameObject collidedObject)
    {
        Destroy(collidedObject);
        Destroy(this.gameObject);
    }
*/
}
