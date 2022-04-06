using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    private Rigidbody2D rigid;

    [Header("Player Attributes")]
    [SerializeField]
    private GameObject Player;

    [Header("Shot Attributes")]
    [SerializeField]
    private float Direction;
    private float Speed = 3.0f;
    private float lifeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Direction = 1;
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(Speed*Direction, 0);
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerDirection(Player) == false)
        {
            Direction = 1;
        }
    }


  

    bool PlayerDirection(GameObject Player)
    {

        return false;
    }
}
