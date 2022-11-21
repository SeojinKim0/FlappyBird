using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;
    TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;    
        scoreText = GetComponent<TextMeshProUGUI>(); 
    }

    void Update()
    {
       scoreText.text = score.ToString(); 
    }

    public void AddScore()
    {
        score++;
    }
}
