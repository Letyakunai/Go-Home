using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public Rigidbody2D rigid;

    [Header("Player Attributes")]
    [SerializeField]
    private GameObject Player;

    [Header("Shot Attributes")]
    [SerializeField]
    private float Direction;
    public float Speed = 3.0f;
    private float lifeTime = 3.0f;
    public GameObject shocked;

    // Start is called before the first frame update
    void Start()
    {
        //Direction = 1;
        rigid = GetComponent<Rigidbody2D>();
        //Old shooting
        //rigid.velocity = new Vector2(Speed*Direction, 0);

        //new shooting
        rigid.velocity = transform.right * Speed * Time.deltaTime;
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    /* void Update()
     {
         if(PlayerDirection(Player) == false)
         {
             Direction = 1;
         }
     }




     bool PlayerDirection(GameObject Player)
     {

         return false;
     }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<AIPatrol>().enabled = false;
            collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
