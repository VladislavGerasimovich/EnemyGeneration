using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private const string Target = "Target";

    [SerializeField] private Enemy _template;

    private Transform _target;

    private void Start()
    {
        _target = transform.Find(Target);
    }

    public void CreateEnemy()
    {
        Enemy enemy = Instantiate(_template, transform.position, Quaternion.identity);
        enemy.Init(_target);
    }
}
