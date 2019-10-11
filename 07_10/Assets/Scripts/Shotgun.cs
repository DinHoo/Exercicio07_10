using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public Weapon arma;

    bool canShoot;

    void Start()
    {
        damage = 7;
        atkRate = 10f;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if (loaded > 0)
            {
                arma.Attack();
            }
            else
            {
                if(ammo > 0)
                {
                    Reload();
                }
                else
                {
                    //mandar mensagem na tela que não tem munição
                }
                
            }
        }
    }
    public override void Attack()
    {

    }
}
