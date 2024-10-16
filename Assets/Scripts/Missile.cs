using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Vector3 direction = new Vector3(0f, 1f, 0f);
    private float speed = 75f;
    private float damage = 10f;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MeteorSmall meteorSmall = collision.GetComponent<MeteorSmall>();
        MeteorBig meteorBig = collision.GetComponent<MeteorBig>();

        if (collision.CompareTag("Upgrade"))
        {
            return;
        }
        if (meteorSmall != null || meteorBig != null)
        {
            if (meteorSmall != null)
            {
                meteorSmall.TakeDamage(damage);
            }

            if (meteorBig != null)
            {
                meteorBig.TakeDamage(damage);
            }
        }
        Destroy(this.gameObject);
    }
    public float GetDamage()
    {
        return damage;
    }
    public void SetDamage(float newDamage)
    {
        damage = newDamage;
    }
}
