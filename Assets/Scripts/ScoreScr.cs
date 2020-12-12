using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScr : MonoBehaviour
{
    public int Score;
    public Text ScoreText;

    void Start()
    {
    }

    void Update()
    {
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore();
    }

    void AddScore()
    {
        Score += 1;
        ScoreText.text = "Score: " + Score.ToString();
    }

}
