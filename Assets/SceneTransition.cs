using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    public string anime;

    public void StartGame()
    {   
       StartCoroutine(LoadScene());
       //transitionAnim.SetTrigger("end");
       //SceneManager.LoadScene("Main");


    }
    public void Exit()
    {
        Application.Quit();
    }
    IEnumerator LoadScene()
    {   
        transitionAnim.SetTrigger("isending");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Main");

    }
}
