using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShootingWithAmmo : Shooting
{
    public SingleShootingWithAmmo(BulletSpawner spawner) : base(spawner) { }

    public override void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
            BulletSpawner.Spawn().Init(BulletSpawner.transform.forward);
        }
    }
}
