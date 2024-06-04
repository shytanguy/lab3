using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] private WeaponFlyweight _weaponFlyweight;

    private float _currentBullets;

    [SerializeField] private SpriteRenderer _Renderer;
    void Start()
    {
        _Renderer.color = _weaponFlyweight.WeaponColor;

        Reload();

        for(int i = 0; i < _weaponFlyweight.bulletsAmount; i++)
        {
            Shoot();
        }
    }

 
    private void Shoot()
    {
        Debug.Log($"shoot from {name}");
        if (_currentBullets > 0)
            _currentBullets -= 1;
        if (_currentBullets<=0)
            Reload();
    }

    private void Reload()
    {
        Debug.Log($"reload {name}");
        _currentBullets = _weaponFlyweight.bulletsAmount;
    }
}
