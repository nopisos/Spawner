using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Vector3[] _points;
    [SerializeField] private int _maxQuantity;
    [SerializeField] private float _createTime;

    private float _time;
    private int _quantity = 0;

    void Start()
    {
        _time = _createTime;
    }

    void Update()
    {       
        _time += Time.deltaTime;
        if (_quantity != _maxQuantity && _time >= _createTime)
        {
            Instantiate(_prefab, _points[Random.Range(0, _points.Length)], Quaternion.identity);
            _quantity++;
            _time = 0;
        }
    }
}
