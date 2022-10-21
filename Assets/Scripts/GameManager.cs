using System.Collections;
using System.Collections.Generic;
using UnityEngine;                                                                                                          //Bizim oyun 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameEnd = false; 
    public ScoreManager _scoremanager;
    
    private ScoreManager theScoreManager;
    public GameOverScript _gameoverscript;

    void Start()
    {
        instance = this;
        Time.timeScale=1f;
        //theScoreManager=FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }


    public void GameOver()
    {
        if (gameEnd == true)
        {
            Debug.Log("Game Over TRUE");
            _gameoverscript.Setup(_scoremanager.scoreCount);
            //gameoverMenu.SetActive(true);
            Time.timeScale = 0f;
            //theScoreManager.scoreIncreasing=false;
            
            
        }

         /*if(gameEnd == false){
            Time.timescale=1f;
        }*/

}
}
