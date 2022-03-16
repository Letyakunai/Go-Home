using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 3.0f;
    void Start()
    {
        
    }

    void MoveWithKeyboard()
    {
        //Button Press Checker
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithKeyboard();
    }
}
