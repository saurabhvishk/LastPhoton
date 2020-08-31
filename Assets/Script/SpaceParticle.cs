using UnityEngine;

public class SpaceParticle : MonoBehaviour
{
    // Start is called before the first frame update
    //private Vector3 screenBoundries;
    public Vector3 offset =new Vector3 (0,0,0);
    public Transform pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   //screenBoundries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //transform.position = new Vector3(screenBoundries.x-45, screenBoundries.y/2, transform.position.z);
        transform.position =pos.position + offset;
    }
}
