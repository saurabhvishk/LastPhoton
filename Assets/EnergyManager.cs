using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    public static EnergyManager instance ;
    int energyBar;
    public Text text;
    public EnergyControl eControl;
    // Start is called before the first frame update
    void Start()
    {   
        if (instance ==  null)
            instance = this;
        int maxEnergy = 4;
        eControl.SetMaxEnergy(maxEnergy);


        
    }

    public void EnergyBar(int energyCoin)
    {
        energyBar+=energyCoin;
        
        eControl.SetEnergy(energyBar);
    }
  
}

