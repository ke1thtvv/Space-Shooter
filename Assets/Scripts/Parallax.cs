using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float backgroundSpeed = 0.05f;
    private float speedIncrease = 0.01f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        backgroundSpeed += speedIncrease * Time.deltaTime;
        meshRenderer.material.mainTextureOffset += new Vector2(0, backgroundSpeed * Time.deltaTime);
    }
}
