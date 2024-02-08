using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject m_Projectile;    
    public Transform m_SpawnTransform;

    private float timeIncrement;
    private float shootTime;
    private float currentTime;
    private float shootInterval = 1;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = Time.time;
        shootTime = currentTime + shootInterval;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
        if (currentTime > shootTime)
        {
            Instantiate(m_Projectile, m_SpawnTransform.position, m_SpawnTransform.rotation);
            shootTime = currentTime + shootInterval;
        }

        
    }
}