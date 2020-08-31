using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{   
    [SerializeField]
    [Range(2,40)]
    private float speed = 4;
    [SerializeField]
    [Range(2,720)]
    private float radius = 4;    

    private Vector3 targetPosition;
    private bool isMoving;
    public Transform pivitpoint ;
    

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z =transform.position.z;
        isMoving = true;
    }

    void Move()
    {   
        
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
    
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
        if (targetPosition == transform.position)
        {
                isMoving = false;
        }
        

    }

  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if(isMoving)
        {
            Move();
        }
        if (Input.GetButton("Jump"))
            
        {   
            //Debug.Log("rotate");
            
        

            transform.RotateAround(pivitpoint.position, new Vector3(0f,0f,1f), radius * Time.deltaTime);


            
        }
        
    }
}
