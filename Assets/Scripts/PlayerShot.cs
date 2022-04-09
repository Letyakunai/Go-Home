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
    public float Speed = 100.0f;
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
        rigid.velocity = transform.right * (Speed);

        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
     void Update()
    {
        Speed += Speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<AIPatrol>().enabled = false;
            collision.gameObject.GetComponent<EnemyMDamage>().Hit = false;
            collision.gameObject.GetComponent<EnemyMDamage>().invunTimer = 0;
            collision.gameObject.GetComponent<EnemyMDamage>().enabled = false;
            collision.gameObject.GetComponent<EnemyMDamage>().Damage = 0;
            collision.gameObject.GetComponent<EnemyMDamage>().Score = 0;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.GetComponent<Transform>().Rotate(new Vector3(0,0,-90));
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
}
