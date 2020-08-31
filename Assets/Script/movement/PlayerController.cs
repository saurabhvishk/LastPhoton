using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Vector2 screenBoundries;
    /*
    float smooth = 10.0f;
    float tiltAnglez1 = 60.0f;
    
    float tiltAnglez2 = 0.0f;
    float tiltAnglez3 = 180.0f;
    */

        
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        screenBoundries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput* speed;
        //Debug.Log(transform.rotation.GetType());
        // Smoothly tilts a transform towards a target rotation.
        
        
        
        
    }

    void FixedUpdate()
    {  //rb.MovePosition(rb.position + Vector2.one);
       rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
       
 
    }

}
