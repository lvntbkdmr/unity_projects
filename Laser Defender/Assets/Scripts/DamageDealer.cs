using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    //Config parameters
    [SerializeField] int damage = 100;


    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        //This assumes that the damaging object is a laser beam, so while hitting, it destroys the laser
        //However, when an enemy and player collides, it also destroy the enemy ship in here in the assumption of that ship being a laser beam
        //Levent B.
        Destroy(gameObject);
    }
}
