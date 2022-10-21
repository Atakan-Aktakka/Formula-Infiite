using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text pointsText;
    private int currentScn;
    public void Setup(float score)
    {
        gameObject.SetActive(true);
       // pointsText.text=score.ToString()+"Score:";
    }


    public void RestartButton()
    {
        currentScn= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScn);
        GameManager.instance.gameEnd = false;
        //Time.timescale=1f;


 
    }
   
}
