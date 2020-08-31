using UnityEngine;
using UnityEngine.SceneManagement;





public class DeathMenu : MonoBehaviour
{   
    public static bool GameIsPaused = false;
    public  GameObject deathMenuUI;
    
    //public Animator transitionAnim;

    private static bool isPlayerDead = Pull.playerDead;
    

    
     public void PlayerDead()
    {
                
                Debug.Log("isplayerdead");
                deathMenuUI.SetActive(true);
                Debug.Log("yes");

            
    }
}
    

