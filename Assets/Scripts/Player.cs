using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player I;
    
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
