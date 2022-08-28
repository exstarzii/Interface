using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSlider : MonoBehaviour
{
    public Image[] imageComp;
    public Color activeColor;
    public Color normalColor;

    public void OnElementClick(int elementPosition)
    {
        if (elementPosition < 0 || elementPosition > imageComp.Length)
        {
            return;
        }
        for (int i = 0; i <= elementPosition; i++)
        {
            imageComp[i].color = activeColor;
        }
        for (int i = elementPosition + 1; i < imageComp.Length; i++)
        {
            imageComp[i].color = normalColor;
        }

    }
}
