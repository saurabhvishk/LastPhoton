using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ReverseFX : TimeController
{   

    //post processing data
    
    public PostProcessVolume volume;
    public float bloom = 0f;
    public float saturation = 50f;
    public float lensDistortion = -100f;
    public float intensityAO = 20f;
    private Bloom bloomLayer;
    private AmbientOcclusion ambientOcclusionLayer;
    private ColorGrading colorGradingLayer;
    private LensDistortion lensDistortionLayer;


    // Start is called before the first frame update
    void Start()
    {
            
            volume.profile.TryGetSettings(out bloomLayer);
            volume.profile.TryGetSettings(out ambientOcclusionLayer);
            volume.profile.TryGetSettings(out colorGradingLayer);
            volume.profile.TryGetSettings(out lensDistortionLayer);
    }

    // Update is called once per frame
    void FixedUpdate()

    {    
        if(isReversing){
            ambientOcclusionLayer.enabled.value = true;
            ambientOcclusionLayer.intensity.value = intensityAO;
 
            bloomLayer.enabled.value = true;
            bloomLayer.intensity.value = bloom;
 
            colorGradingLayer.enabled.value = true;
            colorGradingLayer.saturation.value = saturation;

            lensDistortionLayer.enabled.value = true;
            lensDistortionLayer.intensity.value = lensDistortion;
        }

        else
        {
            ambientOcclusionLayer.enabled.value = false;
 
            bloomLayer.enabled.value = false;
 
            colorGradingLayer.enabled.value = false;

            lensDistortionLayer.enabled.value = false;
        }
        
    }
}
