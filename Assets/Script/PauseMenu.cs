using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class PauseMenu : MonoBehaviour
{   
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    
    public Animator transitionAnim;


    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {   transitionAnim.SetTrigger("end");
        
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused=false;
        
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        GameIsPaused=true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game");
    
       SceneManager.LoadScene("Start");

    }
     public void Replay()

    {   //isPlayerDead =false;
        transitionAnim.SetTrigger("start");
        SceneManager.LoadScene("Main");
    }
    
}
