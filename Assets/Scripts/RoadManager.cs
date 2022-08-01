using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> roadPresets;
    [SerializeField] private List<GameObject> _generatedRoads = new();
    
    private List<int> _pickedRoads = new();

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

    public void InitRoads()
    {
        var i = 0;
        while (i < 10)
        {
            Instantiate(GetRandomRoad(), GetNextPos(), Quaternion.identity);
            i++;
        }
    }

    private Vector3 GetNextPos()
    {
        const float a = GameManager.RoadInterval;
        var sin15 = Mathf.Sin(((float)Math.PI / 180) * 15);
        var cos15 = Mathf.Cos(((float)Math.PI / 180) * 15);
        var x = a * sin15 * cos15;
        var y = a * cos15 * cos15;
        Debug.Log("x, y:" + x + ", " + y );
        return transform.position + new Vector3(x , y , 0) * GameManager.I.GetAndSetRoadCounts();
    }
    
    private GameObject GetRandomRoad()
    {
        var count = roadPresets.Count;
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
        }

        var road = roadPresets[idx];

        _generatedRoads.Add(road);
        return road;
    }
}
