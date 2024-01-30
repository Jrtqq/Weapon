using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleShooting : IShoot
{
    private const int LeftMouseButton = 0;

    private BulletSpawner _spawner;
    private int _bulletsPerShot = 3;

    public MultipleShooting(BulletSpawner spawner)
    {
        _spawner = spawner;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            for (int i = 0; i < _bulletsPerShot; i++)
            {
                Quaternion rotation = Quaternion.Euler(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
                _spawner.Spawn().Init(rotation * _spawner.transform.forward);
            }
        }
    }
}
