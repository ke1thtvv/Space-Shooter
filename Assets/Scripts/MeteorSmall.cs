using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSmall : Meteroite
{
    [SerializeField] private ParticleSystem destroyed;
    [SerializeField] private Sprite[] smallstates;
    [SerializeField] private UpgradeSpawner upgradeSpawner;

    private SpriteRenderer spriteRenderer;
    private float maxHealth;
    private float health;
    private float damage;
    private int points;
    private TextUpdate textUpdater;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxHealth = 30f;
        health = maxHealth;
        damage = 25;
        points = 100;
        textUpdater = FindObjectOfType<TextUpdate>();
    }
    public override void SetUpgradeSpawner(UpgradeSpawner spawner)
    {
        upgradeSpawner = spawner;
    }
    public override void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= maxHealth * 2/3)
        {
            spriteRenderer.sprite = smallstates[1];
        }
        if (health <= maxHealth * 1/3)
        {
            spriteRenderer.sprite = smallstates[2];
        }
        if (health <= 0)
        {
            Explode();
            textUpdater.UpdateScore(points);

        }
    }
    public override float GetDamage()
    {
        return damage;
    }
    public override void Explode()
    {
        ParticleSystem destroyedEffect = Instantiate(destroyed, transform.position, Quaternion.identity);
        destroyedEffect.Play();
        Destroy(gameObject);
        if (upgradeSpawner != null)
        {
            upgradeSpawner.SpawnUpgrade(transform.position);
        }
    }
}
