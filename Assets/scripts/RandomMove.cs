using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    [Range(1,5)]
    [SerializeField] private float _speed;
    
    private Transform _transform;
    private Vector2 _target;
    private float _time = 5;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _time += Time.deltaTime;
        _transform.Translate(_target*_speed*Time.deltaTime);
        if(_time > 4)
        {
            _target.x = Random.Range(-1f, 1f);
            _target.y = Random.Range(-1f, 1f);
            _time = 0;
        }
    }
}
