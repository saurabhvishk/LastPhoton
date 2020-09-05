using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrationController : MonoBehaviour
{   

    public Text text1;
    public Text text2;
    public float smooth= 5f;
    public bool isZooming= false;
    public GameObject lastSpawn;
    


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Texton",2); 
        
        
    }
    // Update is called once per frame
    void Update()
    {  
        if (isZooming)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 50f, Time.deltaTime*smooth);
            if(Camera.main.orthographicSize== 50f)
            Time.timeScale = 0f;
        }
      
    }

    void Texton()
    {
        text1.enabled = true;
        Invoke("Textoff",2);
    }
    void Textoff()
    {
        text1.enabled = false;
        Invoke("Text2On",2);
        
    }
    void Text2On()
    {   text2.enabled = true;
        //text2.transform.localScale+= new Vector3 (0.5f,0.5f,0.5f);
        Invoke("Text2Off",3);

    }
    void Text2Off()
    {   
        text2.enabled = false;
        isZooming= true;
        lastSpawn.GetComponent<spawn>().UniversePop();
       
    
        
        
    }
}
