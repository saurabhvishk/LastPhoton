using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gravity : MonoBehaviour
    {   
        public static List<Gravity> Attractors ;  
        const float G = 6.67f;


        public Rigidbody2D rb ;
        void FixedUpdate()
        {
            // Gravity[] attractors = FindObjectOfType<Gravity>();
            foreach(Gravity attractor in Attractors)
            {
                if(attractor != this)
                    Attract(attractor);

            }

        }
        void OnEnable()
        {
            if(Attractors == null)
            Attractors = new List<Gravity>();
            Attractors.Add(this);
        
            
        }
        void OnDisable()
        {
            Attractors.Remove(this);
        }
        void Attract(Gravity objToAttract)
        {
            Rigidbody2D rbToAttract = objToAttract.rb;
            Vector3 direction;
            if(objToAttract.tag == "StarBirth" || this.tag == "StarBirth")
            {
                direction = -(rb.position -rbToAttract.position);
            }
            else
            {
                direction = rb.position - rbToAttract.position;
            }
            float distance = direction.magnitude;

            // if(distance < 60 )
            // {
            //     Time.timeScale = 1/Mathf.Log(distance)+ 0.3f;
            //     Debug.Log("slow slow");
            // }
            // else
            // Time.timeScale =1f;
            


            float forceMagnitude = (rb.mass*rbToAttract.mass)/Mathf.Pow(distance,2);

            Vector3 force= G *direction.normalized * forceMagnitude;

            rbToAttract.AddForce(force);
        }
    }
