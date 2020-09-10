using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Comet"))
        {
            score++;
            int oldScore = PlayerPrefs.GetInt("score");
            if (score > oldScore) {
                PlayerPrefs.SetInt("score", score);
                PlayerPrefs.Save();
            }
        }
    }
}
