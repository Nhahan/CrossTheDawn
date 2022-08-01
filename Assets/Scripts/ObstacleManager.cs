using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacles;
    
    private List<int> _pickedObstacles;
    
    public static ObstacleManager I;
    
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
    
    public GameObject GetRandomObstacle()
    {
        var count = obstacles.Count;
        int idx;
        while (true) 
        {
            idx = Random.Range(0, count);
            if (!_pickedObstacles.Contains(idx)) break; // 같은 숫자 아닐 때까지 뽑기
        }

        _pickedObstacles.Add(idx); // 뽑은 숫자 뽑은 리스트에 넣기
        if (_pickedObstacles.Count > count / 1.5)
        {
            _pickedObstacles.Clear();
            Debug.Log("_pickedObstacles.Clear() / count : " + _pickedObstacles.Count);
        }
        return obstacles[idx];
    }
}
