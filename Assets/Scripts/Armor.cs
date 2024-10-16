using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Upgrade
{
    private float amount = 15;
    public override void GetUpgrade(GameObject player)
    {
        Spaceship spaceship = player.GetComponent<Spaceship>();
        if (spaceship != null)
        {
            spaceship.SetArmor(amount);
        }
    }
    public override void Dissapear()
    {
        Destroy(gameObject);
    }
}
