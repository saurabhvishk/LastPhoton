﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    
    float orthoSize = 10000;
    public Transform spawnPos ;
    public GameObject spawnObj;
    float timer = 0f;  

    bool isZooming = false;
    public GameObject narrationControler;
    void Start()
    {
        Camera.main.orthographicSize =orthoSize;

    }
    void FixedUpdate()
    {   isZooming = narrationControler.GetComponent<NarrationController>().isZooming;
        
        timer =(timer +Time.deltaTime*50) ;
        if(timer % 50 == 0 && isZooming == false)
            UniversePop();        
    }   
    public void UniversePop()
    {   
        Instantiate(spawnObj,spawnPos.position, spawnPos.rotation);
    }

    
    }
