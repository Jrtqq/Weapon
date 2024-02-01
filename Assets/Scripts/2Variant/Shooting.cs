using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooting
{
    protected int MaxAmmo = 30;
    protected int Ammo;
    protected BulletSpawner BulletSpawner;

    public Shooting(BulletSpawner spawner)
    {
        BulletSpawner = spawner;
        Reload();
    }

    public abstract void Shoot();

    public void Reload()
    {
        Ammo = MaxAmmo;
    }
}
