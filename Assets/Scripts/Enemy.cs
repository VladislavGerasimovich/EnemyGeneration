using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _secondsToDeath;

    private float _elapsedTime = 0;
    
    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _secondsToDeath)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
