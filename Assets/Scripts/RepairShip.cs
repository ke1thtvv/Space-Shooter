using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairShip : Upgrade
{
    private float amount = 30f;
    public override void GetUpgrade(GameObject player)
    {
        Spaceship spaceship = player.GetComponent<Spaceship>();
        if (spaceship != null)
        {
            spaceship.SetHealth(amount);
        }
    }
    public override void Dissapear()
    {
        Destroy(gameObject);
    }
}
