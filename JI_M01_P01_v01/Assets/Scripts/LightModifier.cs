using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModifier : MonoBehaviour
{
    Light directionalLight;
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = this.GetComponent<Light>();
        Score.OnMilestone += changeLightColor;
    }


    public void changeLightColor()
    {
        directionalLight.color = Random.ColorHSV();
    }
}