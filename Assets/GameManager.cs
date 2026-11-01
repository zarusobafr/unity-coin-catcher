using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text scoreText;
    int score = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "SCORE: " + score;
    }
}