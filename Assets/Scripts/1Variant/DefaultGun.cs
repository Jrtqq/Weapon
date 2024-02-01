using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DefaultGun : Gun
{
    protected override void Shoot()
    {
        BulletSpawner.Spawn().Init(transform.forward);
    }
}
