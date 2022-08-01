using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    private int _roadCounts;
    
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

    private void Start()
    {
        RoadManager.I.InitRoads();
    }

    public int GetAndSetRoadCounts()
    {
        Debug.Log("RoadCounts: " + _roadCounts);
        return ++_roadCounts;
    }
}
