using UnityEngine;
using System.Collections;

public class PhotonMoves : MonoBehaviour
{
    [SerializeField]
    [Range(0,100)]
    private float speed = 15f;
    private Vector3 targetPosition;
    private float boostTimer =0f;
    private bool isBoosting =false;
    Vector2 movement;
    public float zoomOut = 26f , zoomIn = 16f;
    

    private Rigidbody2D rb;
    
    void Start()
    {
        rb =this.GetComponent<Rigidbody2D>(); 
        
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
         if(isBoosting)
            {
                boostTimer += Time.deltaTime;
                Debug.Log(boostTimer);
                if(boostTimer >= 5f)
                {   
                    speed = 10f;
                    boostTimer = 0;
                    Debug.Log("zooming In");
                    StartCoroutine (SlowZoom(zoomIn));
                    
                    isBoosting =false;
                    
                    

                }
            }
        
        
         
         
            
            
             
         
        
    }

    void FixedUpdate()
    {
        move(movement);
    }
    void move(Vector2 moveSpeed)
    {
        Vector2  fixSpeed = moveSpeed*speed*Time.deltaTime;
        rb.MovePosition((Vector2)transform.position+fixSpeed);
    }
   
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boost")
        {
            isBoosting= true;
            speed = 40;
            Debug.Log("zooming Out");
            StartCoroutine (SlowZoom(zoomOut));
        }
    }

    void Zoom(float zoomLevel)
    {   float currZoom = Camera.main.orthographicSize;

        if(currZoom >zoomLevel)
        {
            for(float i = currZoom ; i>=zoomLevel ; i--)
            {
                Camera.main.orthographicSize = i;
                  
            }
            Debug.Log("Zoom in");
        }
        else if(currZoom < zoomLevel)
        {
             for(float i = currZoom ; i<=zoomLevel ; i++)
            {
                Camera.main.orthographicSize = i;
                
            }
            Debug.Log("Zoom out");
        } 
         else
         Debug.Log("no effect");
        
    }
    IEnumerator SlowZoom(float zoomLevel)  
    {
        for(;;)
        {
        Zoom(zoomLevel);
        yield return null;
        }

    }


  
}

