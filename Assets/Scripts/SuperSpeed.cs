using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpeed : Upgrade
{
    private float amount = 60f;
    private float originalCooldown;
    public override void GetUpgrade(GameObject player)
    {
        Spaceship spaceship = player.GetComponent<Spaceship>();
        if (spaceship != null)
        {
            originalCooldown = spaceship.GetSpeed();
            spaceship.SetSpeed(amount);
            spaceship.StartCoroutine(RevertCooldownAfterDelay(spaceship, 10f));
        }
    }
    private IEnumerator RevertCooldownAfterDelay(Spaceship spaceship, float delay)
    {
        yield return new WaitForSeconds(delay);
        spaceship.SetSpeed(originalCooldown);
    }
    public override void Dissapear()
    {
        Destroy(gameObject);
    }
}
