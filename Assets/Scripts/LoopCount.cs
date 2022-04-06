using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCount : MonoBehaviour
{

    [SerializeField]
    private int Loops;

    private static LoopCount instance = null;
    public static LoopCount Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<LoopCount>();
                if(instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "LoopCount";
                    instance = go.AddComponent<LoopCount>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {
        
    }

    public void AddCount(int value)
    {
        Loops += value;
    }

    public int ShowCount()
    {
        return Loops;
    }
}
