using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Weapon
{
    bool upgradedBat;

    void Start()
    {
        atkRate = 3f;
    }

    void Update()
    {
        if(upgradedBat == true)
        {
            damage = 5;
        }
        else
        {
            damage = 2;
        }
    }

    public override void Attack()
    {
        //
    }
}
