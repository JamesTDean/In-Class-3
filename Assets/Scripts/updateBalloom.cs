using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateBalloom : MonoBehaviour
{
    public Rigidbody myBody;
    private Vector3 startPosition;
    private float speed;
    private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time;
        myBody = GetComponent<Rigidbody>();
        startPosition = transform.position;
        speed = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        myBody.transform.position = startPosition + new Vector3(0, (Time.time - spawnTime) * speed, 0.0f);
        if (transform.position.y > 15f)
        {
            Destroy(gameObject);
        }
    }
}
