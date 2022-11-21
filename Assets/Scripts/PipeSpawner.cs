using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float maxTime = 1f;
    float timer = 0f;
    [SerializeField] GameObject pipe;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minY, maxY), 0);    
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minY, maxY), 0);
            Destroy(newPipe, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}
