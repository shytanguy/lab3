using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="weapon",menuName ="weaponSO")]
public class WeaponFlyweight : ScriptableObject
{
    public float weight;

    public int bulletsAmount;

    public float ShootingSpeed;

    public Color WeaponColor;
}
