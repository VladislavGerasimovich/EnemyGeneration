using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _delay;

    private Coroutine CreateEnemyJob;
    private object _wait;

    private void Start()
    {
        _wait = new WaitForSeconds(_delay);
        CreateEnemyJob = StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        bool isWorking = true;

        while (isWorking)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            _spawnPoints[spawnPointNumber].CreateEnemy();
            yield return _wait;
        }
    }
}
