using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector3 _endPos;
    private Vector2 _directionNormal;

    private float _speed;
    private float _speedMult = 1f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _directionNormal = (_endPos - transform.position).normalized;
        
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _directionNormal * (_speed * Time.fixedDeltaTime * _speedMult));
    }

    public void SetEndPosAndSpeed(Vector3 endPos, float speed)
    {
        _endPos = endPos;
        _speed = speed;
    }

    public void Stop()
    {
        _speedMult = 0;
    }
}
