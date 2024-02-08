using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour
{
    public float m_Speed = 10f;   
    public float m_Lifespan = 3f; 
    private Rigidbody m_Rigidbody;
    private ChangeText myChangeText;
    private GameObject textManager;


    // Start is called before the first frame update
    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        textManager = GameObject.Find("TextManager");
        myChangeText = textManager.GetComponent<ChangeText>();
    }

    void Start()
    {
        m_Rigidbody.velocity = m_Rigidbody.transform.forward * m_Speed;
        //Destroy(gameObject, m_Lifespan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Balloon")
        {
            myChangeText.changeScore();
            Destroy(gameObject);
            Destroy(collision.transform.gameObject);
        }
    }
}
