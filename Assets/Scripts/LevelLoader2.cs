using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    [SerializeField]
    private int Max_Loops = 2;

    public int LeveltoLoadEnd;
    public int LeveltoLoad;

    public void LoadLevelEnd()
    {
        SceneManager.LoadScene(LeveltoLoadEnd);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(LeveltoLoad);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (LoopCount.Instance.ShowCount() >= Max_Loops) 
            {
                Debug.Log("Worked");
                LoadLevelEnd();
            }
            else
            {
                LoadLevel();
                LoopCount.Instance.AddCount(1);
                Debug.Log("Loop Added");
            }
        }
        
    }
}
