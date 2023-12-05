using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 1f;
    private Transform _target;

    private void Update()
    {
        Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

        if(transform.position == _target.position)
        {
            Destroy(gameObject);
        }
    }

    public void Init(Transform target)
    {
        _target = target;
    }
}
