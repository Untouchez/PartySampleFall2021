﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{

    public override void Shoot(Transform start)
    {
        fireTime -= Time.deltaTime;
        if (fireTime <= 0)
        {
            fireTime = fireRate;
            Debug.Log("pistol shoot");
            Instantiate(bulletPrefab, start.position, start.rotation);
        }
    }
}