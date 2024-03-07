using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI HighScore;

    void Start()
    {
        // Load high score from player preferences
        highScore = PlayerPrefs.GetInt("HighScore", 0);
      
    }

    void UpdateUI()
    {
        // Update score and high score text
        Score.text = "Score: " + score.ToString();
        HighScore.text = "High Score: " + highScore.ToString();
    }

    public void UpdateScore(int points)
    {
        score += points;
        // Check if the current score is higher than the high score
        if (score > highScore)
        {
            highScore = score;
            // Save high score to player preferences
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        UpdateUI();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateUI();
    }
}