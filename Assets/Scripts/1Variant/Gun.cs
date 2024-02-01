using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] protected BulletSpawner BulletSpawner;

    protected readonly int LeftMouse = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouse))
        {
            Shoot();
        }
    }

    protected abstract void Shoot();
}
