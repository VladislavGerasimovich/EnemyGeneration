using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private Coroutine CreateEnemyJob;
    private int _directionX;
    private int _directionY;
    private int _minDirection = -1;
    private int _maxDirection = 2;

    private void Start()
    {
        CreateEnemyJob = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        bool isWorking = true;

        while (isWorking)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            MountDirection();
            Enemy template = Instantiate(_template, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
            template.Init(_directionX, _directionY);
            yield return new WaitForSeconds(_delay);
        }
    }

    private void MountDirection()
    {
        _directionX = Random.Range(_minDirection, _maxDirection);
        _directionY = Random.Range(_minDirection, _maxDirection);

        if(_directionX >= 0)
        {
            _directionX = 1;
        }
        else if( _directionY >= 0)
        {
            _directionY = 1;
        }
    }
}
