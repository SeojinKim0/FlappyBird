using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float speed = 1f;
    void Update()
    {
        
        transform.position += Vector3.left * speed * Time.deltaTime;;
    }
}
