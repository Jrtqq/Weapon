using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 10f;

    private void Update()
    {
        transform.Translate(_direction.normalized * _speed * Time.deltaTime);
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }
}
