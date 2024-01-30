using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShootingWithCartridges : IShoot
{
    private const int LeftMouseButton = 0;

    private BulletSpawner _spawner;
    private int _maxCartridges;
    private int _cartridges;

    public SingleShootingWithCartridges(BulletSpawner spawner, int maxCartridges = 30)
    {
        _spawner = spawner;
        _maxCartridges = maxCartridges;

        Reload();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            if (_cartridges > 0)
            {
                _cartridges--;
                _spawner.Spawn().Init(_spawner.transform.forward);
            }
        }
    }

    public void Reload()
    {
        _cartridges = _maxCartridges;
    }
}
