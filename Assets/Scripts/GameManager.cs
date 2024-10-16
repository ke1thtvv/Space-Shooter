using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float speedIncreaseRate = 0.05f;
    public float currentSpeed = 3f;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }
    private void Start()
    {
        NewGame();
    }
    private void Update()
    {
        currentSpeed += speedIncreaseRate * Time.deltaTime;
    }
    public void ResetGame()
    {
        currentSpeed = 10f;
    }
    public float GetGameSpeed()
    {
        return currentSpeed;
    }
    private void NewGame()
    {
        TextUpdate textUpdate = FindObjectOfType<TextUpdate>();
        if (textUpdate != null)
        {
            textUpdate.ResetHighscore();
        }
        SceneManager.LoadScene("0");
    }
}
