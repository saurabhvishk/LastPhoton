using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnee;

    bool isSpawned= false;
    public float spawnDist ;

    // Start is called before the first frame update
    void Start()
    {   
      
        
       
    }
    void Update()
    {   

        float xDist = player.transform.position.x - this.transform.position.x;
        float yDist =player.transform.position.y -this.transform.position.y;

        if(!isSpawned)
            if((xDist >=-spawnDist && xDist <=spawnDist )  && (yDist >=-spawnDist  && yDist <=spawnDist ) )
            {   
                Instantiate(spawnee, transform.position, transform.rotation );
                isSpawned =true;
            }
    }

  
}
