using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonStart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balloonPrefab;
    private int numberOfBalloons = 5;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -2f;
    public float maxY = 2f;
    private float spawnInterval = 6f;
    private float currentTime;
    private float spawnTime;

    void Start()
    {
        GenerateBalloons();
        currentTime = Time.time;
        spawnTime = currentTime + spawnInterval;
    }
    void Update()
    {
        //Debug.Log(gameObject.transform.position);
        currentTime = Time.time;
        if(currentTime > spawnTime)
        {
            GenerateBalloons();
            currentTime = Time.time;
            spawnTime = currentTime + spawnInterval;
        }
        
    }

    void GenerateBalloons()
    {
        for (int i = 0; i < numberOfBalloons; i++)
        {
            Vector3 spawnLocation = GetRandomPosition();
            GameObject balloon = Instantiate(balloonPrefab, gameObject.transform, true);
            balloon.transform.position = spawnLocation;
        }
    }

    Vector3 GetRandomPosition()
    {
        // Generate random position within specified range
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector3(randomX, randomY, 0f);
    }
}
