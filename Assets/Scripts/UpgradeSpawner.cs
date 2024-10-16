using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UpgradeSpawner : MonoBehaviour
{
    [Serializable]
    private struct SpawnableUpgrade
    {
        public Upgrade prefab;
        [Range(0f, 1f)]
        public float spawnChance;
    }

    [SerializeField] private SpawnableUpgrade[] upgrades;

    public void SpawnUpgrade(Vector3 position)
    {
        float randomValue = UnityEngine.Random.value;

        foreach (var spawnableUpgrade in upgrades)
        {
            if (randomValue < spawnableUpgrade.spawnChance)
            {
                Instantiate(spawnableUpgrade.prefab, position, Quaternion.identity);
                return;
            }

            randomValue -= spawnableUpgrade.spawnChance;
        }
    }
}