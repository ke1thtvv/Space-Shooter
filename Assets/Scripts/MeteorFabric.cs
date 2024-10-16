using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorFabric : MonoBehaviour
{
    [System.Serializable]
    private struct SpawnableObject
    {
        public GameObject prefab;
        [Range(0f, 1f)]
        public float spawnChance;
    }

    [SerializeField] private SpawnableObject[] spawnObject;
    [SerializeField] private float initialSpawnDelay = 3f;
    [SerializeField] private float minSpawnDelay = 1f;
    [SerializeField] private float delayDecreaseRate = 0.05f;
    private float currentSpawnDelay;
    private float spawnRange;

    private void OnEnable()
    {
        spawnRange = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - transform.position.x;
        currentSpawnDelay = initialSpawnDelay * 2;
        Invoke(nameof(Spawn), currentSpawnDelay);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Spawn()
    {
        float spawnPossibility = Random.value;
        float spawnXOffset = Random.Range(-spawnRange, spawnRange);

        foreach (var spawn in spawnObject)
        {
            if (spawnPossibility < spawn.spawnChance)
            {
                Vector3 spawnPosition = transform.position + new Vector3(spawnXOffset, 0f, 0f);
                GameObject meteor = Instantiate(spawn.prefab, spawnPosition, Quaternion.identity);
                break;
            }
            spawnPossibility -= spawn.spawnChance;
        }

        currentSpawnDelay = Mathf.Max(currentSpawnDelay - delayDecreaseRate, minSpawnDelay);

        Invoke(nameof(Spawn), currentSpawnDelay);
    }
}