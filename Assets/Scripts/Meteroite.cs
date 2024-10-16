using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Meteroite : MonoBehaviour
{
    public abstract void TakeDamage(float damage);
    public abstract void SetUpgradeSpawner(UpgradeSpawner spawner);
    public abstract float GetDamage();
    public abstract void Explode();
}
