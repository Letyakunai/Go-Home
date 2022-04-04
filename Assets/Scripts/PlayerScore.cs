using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
  {
    public static int ScoreValue = 0;
    Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + ScoreValue;
    }
}