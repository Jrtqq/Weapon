using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Weapon))]

public class ShootingSwitcher : MonoBehaviour
{
    [SerializeField] private BulletSpawner _spawner;

    private Weapon _weapon;
    private Shooting[] _shootingOtions;

    private void Awake()
    {
        _shootingOtions = new Shooting[]
        {
            new SingleShooting(_spawner), new SingleShootingWithAmmo(_spawner), new TripleShooting(_spawner)
        };

        _weapon = GetComponent<Weapon>();
        _weapon.SetShootingOption(_shootingOtions[0]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _weapon.SetShootingOption(_shootingOtions[0]);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _weapon.SetShootingOption(_shootingOtions[1]);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _weapon.SetShootingOption(_shootingOtions[2]);
        }
    }
}
