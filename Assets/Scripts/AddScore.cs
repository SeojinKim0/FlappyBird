using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{   
    // acces score script 
    Score score;
    
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered");
        score.AddScore();
    }
}
