using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShooting : Shooting
{
    private int _bulletsPerShot = 3;

    public TripleShooting(BulletSpawner spawner) : base(spawner) { }

    public override void Shoot()
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            Quaternion rotation = Quaternion.Euler(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
            BulletSpawner.Spawn().Init(rotation * BulletSpawner.transform.forward);
        }
    }
}
