using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private GameObject rightEnd;
    [SerializeField] private GameObject leftEnd;
    
    private GameObject _obstacle;

    private const float RoadInterval = 1.03f;

    private void Start()
    {
        _obstacle = ObstacleManager.I.GetRandomObstacle(gameObject);
    }
}
