using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMDamage : MonoBehaviour
{
    public PlayerHP Playerhealth;
    public LevelLoader LeveltoLoad;
    public PlayerShot Tazed;
    public SpriteRenderer Player;

    public bool Hit = false;
    public int Damage = 1;
    public int Score = 100;

    //public Invulnerability Invul;

    [Header("Invun Time")]
    [SerializeField]
    private float invunTimer = 5.0f;
    [SerializeField]
    private float invunInterval = 0.0f;


    private void Start()
    {

    }
    private void Update()
    {
        if(Hit == true)
        {
            Player.color = Color.red;
        }

        if(invunTimer > 0)
        {
            invunTimer -= Time.deltaTime * 2;
            Damage = 0;
            Score = 0;
            if (invunTimer < 0)
                invunTimer = 0;
        }

        if (invunTimer == 0)
        {
            Player.color = Color.white;
            Damage = 1;
            Score = 100;
            Hit = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(Hit == false) 
            {
                Hit = true;
                invunTimer = 3;
            }

            if (invunTimer > 0)
            {
                PlayerScore.ScoreValue += Score;
                Playerhealth.health -= Damage;
            }

            if (Playerhealth.health <= 0)
            {
                //DestroySelf(collision.gameObject
                LeveltoLoad.LoadLevel();
                Debug.Log("Ded.");
            }
        }



        if (collision.gameObject.tag == "Bzzt")
        {
            
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (invunTimer <= 0)
            {
                PlayerScore.ScoreValue += Score;
                Playerhealth.health -= Damage;
                invunTimer = 3;
                Hit = true;
            }

            if (Playerhealth.health <= 0)
            {
                //DestroySelf(collision.gameObject
                LeveltoLoad.LoadLevel();
                Debug.Log("Ded.");
            }
        }

 
    }


    /*    private void DestroySelf(GameObject collidedObject)
        {
            Destroy(collidedObject);
            Destroy(this.gameObject);
        }
    */
}
