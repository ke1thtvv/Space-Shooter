using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highscoreText;
    private float score;
    private float speedIncreaseRate = 0.05f;
    private float currentSpeed = 3f;
    public void Update()
    {
        currentSpeed += speedIncreaseRate * Time.deltaTime;
        score += currentSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");

        UpdateHighscore();
    }
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }
    public void UpdateHighscore()
    {
        float highscore = PlayerPrefs.GetFloat("highscore", 0);
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("highscore", highscore);
        }
        highscoreText.text = Mathf.FloorToInt(highscore).ToString("D5");
    }
    public void ResetHighscore()
    {
        PlayerPrefs.SetFloat("highscore", 0);
        PlayerPrefs.Save();
        UpdateHighscore();
    }
}
