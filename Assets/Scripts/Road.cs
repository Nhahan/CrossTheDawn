using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private List<GameObject> roads;
    [SerializeField] private List<GameObject> obstacles;
    [SerializeField] private GameObject rightEnd;
    [SerializeField] private GameObject leftEnd;
    
    private GameObject _road;

    private const float RoadInterval = 1.03f;

    private void Start()
    {
            
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
