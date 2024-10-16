using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierTwo : Upgrade
{
    private float originalDamage;
    public override void GetUpgrade(GameObject player)
    {
        Spaceship spaceship = player.GetComponent<Spaceship>();
        if (spaceship != null)
        {
            Missile missile = spaceship.GetMissile();

            originalDamage = missile.GetDamage();
            missile.SetDamage(originalDamage * 1.5f);
        }
    }
    public override void Dissapear()
    {
        Destroy(gameObject);
    }
}
