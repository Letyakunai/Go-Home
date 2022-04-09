using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject TaserShot;
    public GameObject _Player;
    public Transform shootspawn;
    public Animator animator;

    [Header("Ammo")]
    [SerializeField]
    private int AmmoCount;

    //audio
    [SerializeField]
    private AudioSource StunGunSFX;

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
            StunGunSFX.Play();
            Instantiate(TaserShot, shootspawn.position, shootspawn.rotation);
                animator.Play("Player_Shoot");
                AmmoCount -= 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Gun Pickup")
        {
            Destroy(collision.gameObject);
            AmmoCount += 1;
        }
    }
}
