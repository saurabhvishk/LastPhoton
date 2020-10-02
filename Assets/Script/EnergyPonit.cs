using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPonit : MonoBehaviour
{  
    int eCoin=1;
   private void OnTriggerEnter2D(Collider2D other)
   {        
       
       if(other.tag == "Player")
       {
        EnergyManager.instance.EnergyBar(eCoin);
        PhotonMoves.isntance.speed+=eCoin;
        Destroy(this.gameObject,0.2f);

       }
   } 
}
