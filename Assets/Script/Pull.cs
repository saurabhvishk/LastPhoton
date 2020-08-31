using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{   

    public GameObject deathUI;

    Collider2D blackHole;
    public Rigidbody2D rb;
    
    public GameObject player;
    public float rotationSpeed = - 200f;
    public float pull;
    public static bool playerDead =false;
 
    public float DistanceMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        blackHole = GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0,rotationSpeed)*Time.deltaTime);
       
    }
    void OnTriggerEnter2D(Collider2D blackHole)
    {   
        //rb.AddForce(com.position*pull, ForceMode2D.Force);
        Debug.Log("pull");
        //Vector3 direction = transform.position - com.position;
                
        
        player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, pull);

        //player.transform.position = transform.position;
        StartCoroutine(Delay());
        player.SetActive(false);
        //playerDead = true;
        //Debug.Log(playerDead);
        PlayerDead();
        

               

        //float distance = direction.sqrMagnitude*DistanceMultiplier+ 1; // The distance formula

        // Object mass also affects the gravitational pull
        //rb.AddForce(direction.normalized * (pull / distance) * rb.mass * Time.fixedDeltaTime);
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
    public void PlayerDead()
    {
                
                Debug.Log("isplayerdead");
                deathUI.SetActive(true);
                Debug.Log("yes");

            
    }
}
