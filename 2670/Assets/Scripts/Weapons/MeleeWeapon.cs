using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : WeaponBase
{
    public override void Attack()
    {
        Debug.Log("Melee");
    }
}
