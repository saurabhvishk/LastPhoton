using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{   
    public GameObject player;
    public GameObject deathUI;
    public float rotationSpeed = - 200f;
    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {   
         transform.Rotate(new Vector3(0,0,rotationSpeed)*Time.deltaTime);
        
    }
    void OnTriggerEnter2D(Collider2D blackHole)
    {   

        StartCoroutine(Delay());
        player.SetActive(false);
        PlayerDead();
        

               

        
    }
      public void PlayerDead()
    {
                
                Debug.Log("isplayerdead");
                deathUI.SetActive(true);
                Debug.Log("yes");

            
    }
    IEnumerator Delay()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 2 seconds.
        yield return new WaitForSeconds(1);

        //After we have waited 2 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}

