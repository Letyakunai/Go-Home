using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem_Bullet : MonoBehaviour
{
    public float Speed = 3.0f;
    public float lifeTime = 3.0f;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(-Speed, 0);
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
