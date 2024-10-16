using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
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
        float currentSpeed = gameManager.currentSpeed;

        transform.position += Vector3.down * currentSpeed * Time.deltaTime / 5 * 2;

        if (transform.position.y < bottom)
        {
            Destroy(gameObject);
        }
    }
}
