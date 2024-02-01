using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleshotGun : Gun
{
    private int _bulletsPerShot = 3;

    protected override void Shoot()
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            Quaternion rotation = Quaternion.Euler(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            BulletSpawner.Spawn().Init(rotation * transform.forward);
        }
    }
}
