using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWithAmmo : Gun
{
    private int _maxAmmo = 30;
    private int _ammo;

    private void Awake()
    {
        _ammo = _maxAmmo;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouse))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    protected override void Shoot()
    {
        if (_ammo > 0)
        {
            _ammo--;
            BulletSpawner.Spawn().Init(transform.forward);
        }
    }

    private void Reload()
    {
        _ammo = _maxAmmo;
    }
}
