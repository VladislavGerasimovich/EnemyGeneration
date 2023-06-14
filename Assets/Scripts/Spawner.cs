using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private Coroutine CreateEnemyJob;

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
            Instantiate(_template, _spawnPoints[spawnPointNumber].position, Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}
