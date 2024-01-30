using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private BulletSpawner _spawner;
    private IShoot _shootingVariant;

    private void Awake()
    {
        _shootingVariant = new SingleShooting(_spawner);
    }

    private void Update()
    {
        _shootingVariant.Update();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _shootingVariant = new SingleShooting(_spawner);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _shootingVariant = new SingleShootingWithCartridges(_spawner);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _shootingVariant = new MultipleShooting(_spawner);
        }
    }
}
