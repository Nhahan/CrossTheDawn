using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> roads;
    
    private List<int> _pickedRoads;
    
    public static RoadManager I;
    
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
    public GameObject GetRandomRoad()
    {
        var count = roads.Count;
        int idx;
        while (true) 
        {
            idx = Random.Range(0, count);
            if (!_pickedRoads.Contains(idx)) break; // 같은 숫자 아닐 때까지 뽑기
        }

        _pickedRoads.Add(idx); // 뽑은 숫자 뽑은 리스트에 넣기
        if (_pickedRoads.Count > count / 1.5)
        {
            _pickedRoads.Clear();
            Debug.Log("_pickedRoads.Clear() / count : " + _pickedRoads.Count);
        }
        return roads[idx];
    }
}
