using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarExpanding : MonoBehaviour
{   
    bool isZooming = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(isZooming){
            transform.localScale += new Vector3(0.01f,.01f,.01f);
            if(transform.localScale.x >= 2f)
                isZooming = false;
        
        
        }

        
    }
}