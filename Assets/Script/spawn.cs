using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    public Transform spawnPos ;
    public GameObject spawnObj;
    float timer = 0f;
    void Start()
    {
        UniversePop();
    }

    void FixedUpdate()
    {
        timer =(timer +Time.deltaTime*50) ;
        Debug.Log(Time.deltaTime);
        if(timer % 100 == 0)
        {   //Debug.Log(timer);
            UniversePop();
            
        }
    }
    
    public void UniversePop()
    {
        Instantiate(spawnObj,spawnPos.position, spawnPos.rotation);
    }

    
    }
