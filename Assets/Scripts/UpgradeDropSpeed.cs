using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDropSpeed : MonoBehaviour
{
    private float bottom;
    private GameManager gameManager;

    private void Start()
    {
        bottom = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 10f;
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        transform.position += Vector3.down * 60 * Time.deltaTime;

        if (transform.position.y < bottom)
        {
            Destroy(gameObject);
        }
    }
}
