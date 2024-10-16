using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCanon : Upgrade
{
    private float amount = 0.25f;
    private float originalCooldown;

    public override void GetUpgrade(GameObject player)
    {
        Spaceship spaceship = player.GetComponent<Spaceship>();
        if (spaceship != null)
        {
            originalCooldown = spaceship.GetShootCooldown();
            spaceship.SetShootCooldown(amount);
            spaceship.StartCoroutine(RevertCooldownAfterDelay(spaceship, 15f));
        }
    }
    private IEnumerator RevertCooldownAfterDelay(Spaceship spaceship, float delay)
    {
        yield return new WaitForSeconds(delay);
        spaceship.SetShootCooldown(originalCooldown);
    }
    public override void Dissapear()
    {
        Destroy(gameObject);
    }
}
