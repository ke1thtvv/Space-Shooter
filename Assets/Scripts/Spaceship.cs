using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    [SerializeField] private ParticleSystem destroyed;
    [SerializeField] private Missile missile;
    [SerializeField] private HealthBar healthBar;
    private MeteorFabric spawner;
    private float speed = 40.0f;
    private float shootCooldown = 0.5f;
    private bool canShoot = true;
    private float maxHealth = 100f;
    private float currentHealth;
    private float armor = 0f;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }

        Vector3 left = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 right = Camera.main.ViewportToWorldPoint(Vector3.right);
        float halfWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2.0f;
        float newX = Mathf.Clamp(this.transform.position.x, left.x + halfWidth, right.x - halfWidth);
        this.transform.position = new Vector3(newX, this.transform.position.y, this.transform.position.z);

        if (Input.GetKey(KeyCode.Space) && canShoot)
        {
            Attack();
            canShoot = false;
            Invoke("ResetShootFlag", shootCooldown);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeteorSmall meteorSmall = collision.GetComponent<MeteorSmall>();
        MeteorBig meteorBig = collision.GetComponent<MeteorBig>();
        Upgrade upgrade = collision.GetComponent<Upgrade>();

        if (meteorSmall != null || meteorBig != null)
        {
            if (meteorSmall != null)
            {
                TakeDamage(meteorSmall.GetDamage());
                meteorSmall.Explode();
            }

            if (meteorBig != null)
            {
                TakeDamage(meteorBig.GetDamage());
                meteorBig.Explode();
            }
        }
        if (upgrade != null)
        {
            upgrade.GetUpgrade(gameObject);
            upgrade.Dissapear();
            healthBar.SetHealth(currentHealth);
        }
    }
    public Missile GetMissile()
    {
        return missile;
    }
    private void Attack()
    {
        Vector3 missileOffset = new Vector3(0f, 7.5f, 0f);
        Missile newMissile = Instantiate(this.missile, this.transform.position + missileOffset, Quaternion.identity);
        newMissile.SetDamage(missile.GetDamage());
    }
    private void ResetShootFlag()
    {
        canShoot = true;
    }
    public void TakeDamage(float damage)
    {
        float remainingDamage = Mathf.Max(0, damage - Mathf.FloorToInt(armor));
        armor = Mathf.Max(0, armor - damage);
        currentHealth -= remainingDamage;

        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        ParticleSystem destroyedEffect = Instantiate(destroyed, transform.position, Quaternion.identity);
        destroyedEffect.Play();
        this.gameObject.SetActive(false);

        GameObject spawnerObject = GameObject.FindWithTag("Spawner");
        if (spawnerObject != null)
        spawnerObject.SetActive(false);

        Barrier[] meteors = FindObjectsOfType<Barrier>();
        foreach (var meteor in meteors)
        {
            Destroy(meteor.gameObject);
        }
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
            gameManager.ResetGame();

        Invoke("LoadMenu", 2f);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("1");
    }
    public void SetHealth(float newHealth)
    {
        currentHealth += newHealth;
        currentHealth = Mathf.Clamp(currentHealth, 0, 100);
    }
    public float GetSpeed()
    {
        return speed;
    }
    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    public float GetShootCooldown()
    {
        return shootCooldown;
    }
    public void SetShootCooldown(float newShootCooldown)
    {
        shootCooldown = newShootCooldown;
    }
    public float GetArmor()
    {
        return armor;
    }
    public void SetArmor(float newArmor)
    {
        armor += newArmor;
    }
}
