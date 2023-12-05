using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _directionX;
    private int _directionY;

    private void Update()
    {
        transform.Translate(_directionX * Time.deltaTime, _directionY * Time.deltaTime, 0);
    }

    public void Init(int directionX, int directionY)
    {
        _directionX = directionX;
        _directionY = directionY;
    }
}
