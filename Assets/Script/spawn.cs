using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    
    float orthoSize = 10000;
    public Transform spawnPos ;
    public GameObject spawnObj;
    float timer = 0f;  
    void Start()
    {
        Camera.main.orthographicSize =orthoSize;
    }
    void FixedUpdate()
    {
        timer =(timer +Time.deltaTime*50) ;
        if(timer % 50 == 0)
            UniversePop();        
    }   
    public void UniversePop()
    {   
        Instantiate(spawnObj,spawnPos.position, spawnPos.rotation);
    }

    
    }
