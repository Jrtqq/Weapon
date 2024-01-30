using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SingleShooting : IShoot
{
    private const int LeftMouseButton = 0;

    private BulletSpawner _spawner;

    public SingleShooting(BulletSpawner spawner)
    {
        _spawner = spawner;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            _spawner.Spawn().Init(_spawner.transform.forward);
        }
    }
}
