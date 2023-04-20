using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChar : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private SpriteRenderer _spriteChar;
    private Vector3 _input;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _input = new Vector3(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;

        if(_input.x != 0)
        {
            _spriteChar.flipX = _input.x > 0 ? false : true;
        }
    }
}
