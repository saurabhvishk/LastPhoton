using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GForce : MonoBehaviour
{
     
     public float maxGravDist = 4.0f;
     public float maxGravity = 35.0f;

     Vector3 force;
 
     GameObject[] planets;
     public GameObject bHole;
 
     void Start () {
         //planets = GameObject.FindGameObjectsWithTag("BlackHole");
         bHole= new GameObject();
     }
     
     void FixedUpdate () {
         /*
         foreach(GameObject planet in planets) {
             float dist = Vector3.Distance(planet.transform.position, transform.position);
             Debug.Log(" black hole "+planet.transform.position);
             Debug.Log("photon" + transform.position);
             Debug.Log(dist);
             if (dist <= maxGravDist) {
                 Debug.Log("entered");
                 Vector3 v = planet.transform.position - transform.position;
                 force = v.normalized * (1.0f - dist / maxGravDist) * maxGravity;
                 Debug.Log(v);
                 GetComponent<Rigidbody2D>().AddForce(force);
             }

             */
             Debug.Log("bhole"+ bHole.transform.position);
             Debug.Log("photon"+ transform.position);
            float dist = Vector3.Distance(bHole.transform.position, transform.position);
            if (dist <= maxGravDist) {
                 Debug.Log("entered");
                 Vector3 v = bHole.transform.position - transform.position;
                 force = v.normalized * (1.0f - dist / maxGravDist) * maxGravity;
                 Debug.Log(v);
                 GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Force);
         }


     }
 }
