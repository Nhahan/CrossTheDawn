using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public int roadCounts = 1;
    
    public static GameManager I;
    
    private void Awake()
    {
        Application.targetFrameRate = 60;

        if (I == null)
        {
            I = this;
        } 
        else if (I != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
