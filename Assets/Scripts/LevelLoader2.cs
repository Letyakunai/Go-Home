using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    public int counter;
    
    public int LeveltoLoadEnd;
    public int LeveltoLoad;

    public void LoadLevelEnd()
    {
        SceneManager.LoadScene(LeveltoLoad);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(LeveltoLoad);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            LoadLevel();
            counter += 1;
        }
        if (counter == 2)
        {
            SceneManager.LoadScene(LeveltoLoadEnd);
        }
    }
}
