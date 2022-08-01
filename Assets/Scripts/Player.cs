using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player I;

    public float jumpInterval;
    
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
}
