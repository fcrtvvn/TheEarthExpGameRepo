using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public Material normalSky, redSky;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void BarValueSetter(float value, float waterAmountValue)
    {
        float lowCO2value = 1000;

        float valueToSet = 0;

        if (value > lowCO2value)
        {
            valueToSet = 0;
        }

        if (value < 0)
        {
            valueToSet = 1000;
        }
        else
        {
            valueToSet = lowCO2value - value;
        }

        slider.value = valueToSet;

        if (value <= 300f)
        {
            RenderSettings.skybox = redSky;
            waterAmountValue = waterAmountValue / 3;
        }
        else
        {
            RenderSettings.skybox = normalSky;
        }
    }

    //private void Start()
    //{
    //    BarValueSetter(-1000, 1000);
    //}

}

