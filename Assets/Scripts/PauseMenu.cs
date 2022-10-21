using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static PauseMenu pauseM;
    private int currentScn;
    public bool isPaused=false;
    [SerializeField] GameObject pauseButton; 

    
    
    private void Update()
    {
        //Debug.Log(Time.timeScale);
        if (GameManager.instance.gameEnd == true)
        {
            pauseMenu.SetActive(false);
            pauseButton.SetActive(false);

        }
       
        

    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        
        Time.timeScale = 0f ;
        isPaused = true;
        Debug.Log("Pause true oldu");
            
    }

    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Reset()  //Restart
    {
        currentScn= SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScn);
        Time.timeScale = 1f;
    }

}
