using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShooting : Shooting
{
    public SingleShooting(BulletSpawner spawner) : base(spawner) { }
 
    public override void Shoot()
    {
        BulletSpawner.Spawn().Init(BulletSpawner.transform.forward);
    }
}
