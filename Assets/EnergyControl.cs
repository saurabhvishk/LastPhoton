using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyControl : MonoBehaviour
{

    public Slider slider;

    public void SetEnergy(int health)
    {
      slider.value = health;  
    }
    public void SetMaxEnergy(int maxHealth)
    {
        slider.maxValue = maxHealth;
        
    }
}
