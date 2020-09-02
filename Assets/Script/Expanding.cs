using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Expanding  : MonoBehaviour 
{   
    public float limitScaleX = 200f;
    SpriteRenderer spriteRenderer;
    Color colorVal;
    
   
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);
        

    }

    // Update is called once per frame
    void Update()
    {   

        this.transform.localScale += new Vector3 (0.5f,0.5f,0.5f);
        if(this.transform.localScale.x >= limitScaleX)
        {   
            this.transform.localScale += new Vector3 (1f,1f,1f);
            
            
        }

        if(this.transform.localScale.x >= 100000f)
        {
            Destroy(this.gameObject);
        }

       }
}