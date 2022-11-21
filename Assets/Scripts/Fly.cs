using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] float velocity = 1f;
    private Rigidbody2D rb;
    [SerializeField] GameManager gameManager;
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           // Jump
           rb.velocity = Vector2.up * velocity; 
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        gameManager.GameOver();
    }
}
