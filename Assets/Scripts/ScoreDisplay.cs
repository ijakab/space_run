using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("score");
        scoreDisplay.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
