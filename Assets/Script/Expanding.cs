using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Expanding  : MonoBehaviour 
{   
    public float limitScaleX = 200f;
    SpriteRenderer spriteRenderer;
    Color colorVal;
    GameObject narrController;
    bool isZooming = false;
    
   
    // Start is called before the first frame update
    void Start()
    {      
        narrController = GameObject.Find("Canvas");
        isZooming = narrController.GetComponent<NarrationController>().isZooming;
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        //Debug.Log(isZooming);
        if(isZooming)
        {
            spriteRenderer.color = Color.red;
            //Debug.Log(" Red");
        }
            
        else
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

        if(this.transform.localScale.x >= 8000f)
        {
            Destroy(this.gameObject);
        }

       }
}