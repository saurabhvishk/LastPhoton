using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   public Text score;
    float timer;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {   timer= timer + Time.deltaTime;
        score.text= timer.ToString();
    }
}
