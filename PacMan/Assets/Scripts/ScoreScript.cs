﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;





    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + scoreValue;
       

        if(scoreValue == 98)
        {
            SceneManager.LoadScene(1);
            scoreValue = scoreValue + 1;
        }
        
        if (scoreValue == 372)
        {
            SceneManager.LoadScene("Win");
            scoreValue = scoreValue - 1;
        }
        
    }
    
}
