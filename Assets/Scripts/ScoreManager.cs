using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; 
    public Text hiScoreText;
    public float scoreCount,hiScoreCount;

    public float pointsPerSecond;
    [SerializeField] public bool scoreIncreasing;


    void Start()
    {
        
    }

    
    public void Update()
    {

        if(scoreIncreasing)
        {
            scoreCount +=pointsPerSecond * Time.deltaTime;
        }

        
        if(scoreCount > hiScoreCount)
        {
            hiScoreCount =scoreCount;

        }

        
        scoreText.text="Score: " + Mathf.Round (scoreCount);
        hiScoreText.text= "Highest: " + Mathf.Round (hiScoreCount);


    }
}
