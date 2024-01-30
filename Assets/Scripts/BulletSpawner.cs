using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;

    public Bullet Spawn()
    {
        return Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
    }
}
