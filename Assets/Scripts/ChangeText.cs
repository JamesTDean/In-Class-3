using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string newText = "Current Score: " + score.ToString();
        myText.SetText(newText);
    }

    public void changeScore()
    {
        score += 1;
    }
}
