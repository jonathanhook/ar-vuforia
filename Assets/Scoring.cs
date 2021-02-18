using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private const string TEXT_FORMAT = "Score: {0}";

    public Text scoreText;
    public string tagFilter = "Ball";

    private int score;
    
    void Start()
    {
        score = 0;
        UpdateScore(score);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject ball = other.gameObject;
        if(ball.tag == tagFilter)
        {
            score++;
            UpdateScore(score);

            Destroy(ball);
        }
    }

    private void UpdateScore(int value)
    {
        scoreText.text = string.Format(TEXT_FORMAT, value);
    }

}
