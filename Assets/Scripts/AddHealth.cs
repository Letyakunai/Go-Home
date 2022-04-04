using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour
{
    public float healthBonus = 1f;
    public PlayerHP Playerhealth;
    void Awake()
    {
        playerHP = FindObjectOfType<PlayerHP>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (playerHP.health < PplayerHP.numOfHearts)
        {
            Destroy(gameObject);
            playerHP.health = playerHP.health + healthBonus;
        }
    }


}
