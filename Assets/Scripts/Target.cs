using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private int _currentPoint;
    private float _speed = 1f;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while(true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);

            if(transform.position == _points[_currentPoint].position)
            {
                _currentPoint++;
            }

            if(_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }

            yield return null;
        }    
    }
}
