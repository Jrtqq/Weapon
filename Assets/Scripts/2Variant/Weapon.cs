using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShootingSwitcher))]

public class Weapon : MonoBehaviour
{
    private readonly int LeftMouse = 0;

    private Shooting _shootingOption;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouse))
        {
            _shootingOption.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _shootingOption.Reload();
        }
    }

    public void SetShootingOption(Shooting shooting)
    {
        _shootingOption = shooting;
    }
}
