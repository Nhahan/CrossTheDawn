using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Road : MonoBehaviour
{
    [SerializeField] private Transform rightEnd;
    [SerializeField] private Transform leftEnd;
    
    private GameObject _obstacle;
    private Vector3 _startPos;
    private Vector3 _endPos;
    private float _generateDelay;
    private float _obstacleSpeed;

    private void Start()
    {
        var randomNum = Random.Range(0, 2);
        if (randomNum == 0)
        {
            _startPos = rightEnd.position;
            _endPos = leftEnd.position;
        }
        else
        {
            _startPos = leftEnd.position;
            _endPos = rightEnd.position;
        }
        
        if (gameObject.CompareTag("Road"))
        {
            _generateDelay = Random.Range(2f, 4f);
            _obstacleSpeed = Random.Range(0.8f, 2f);
            _obstacle = ObstacleManager.I.GetRandomObstacle();
            
            StartCoroutine(GenerateObstacle());
        }
    }

    private IEnumerator GenerateObstacle()
    {
        while(true)
        {
            Instantiate(_obstacle, _startPos, Quaternion.identity).GetComponent<Obstacle>().SetEndPosAndSpeed(_endPos, _obstacleSpeed);
            yield return new WaitForSeconds(_generateDelay);
        }
    }
}
