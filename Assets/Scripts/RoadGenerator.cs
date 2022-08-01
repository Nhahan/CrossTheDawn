using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private GameObject rightEnd;
    [SerializeField] private GameObject leftEnd;
    
    private GameObject _road;
    private GameObject _obstacle;

    private const float RoadInterval = 1.03f;

    private void Start()
    {
        _road = ObstacleManager.I.GetRandomObstacle();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
