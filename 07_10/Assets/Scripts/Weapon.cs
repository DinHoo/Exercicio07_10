using UnityEngine;

public class Weapon
{

    //dano da arma
    public int damage;


    //qtddade de munição
    public int ammo;


    //vel de atk da arma
    public float atkRate;


    //quantas balas tem carregadas
    public int loaded;

    public virtual void Attack()
    {
        //
    }

    public virtual void Reload()
    {
        //
    }
    public enum Arma
    {
        BAT, SHOTGUN
    };
}