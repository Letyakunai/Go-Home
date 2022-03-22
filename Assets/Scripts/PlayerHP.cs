using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] Hearts;
    public Sprite Full_Heart;
    public Sprite Empty_Heart;

    // Update is called once per frame
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < health)
            {
                Hearts[i].sprite = Full_Heart;
            } else
            {
                Hearts[i].sprite = Empty_Heart;
            }
            if (i < numOfHearts)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
    }
}
    
