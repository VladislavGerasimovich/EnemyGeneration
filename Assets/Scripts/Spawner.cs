using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    void Update()
    {
        _elapsedTime += Time.deltaTime;
        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

        if(_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;
            Instantiate(_template, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
        }
    }
}
