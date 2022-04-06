using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    [Header("Ammo")]
    [SerializeField]
    private int AmmoCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if(AmmoCount >= 1)
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
