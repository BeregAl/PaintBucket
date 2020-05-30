using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BucketGraphics : MonoBehaviour
{
    [SerializeField]
    private Image bucketImage;
    [SerializeField]
    private TextMeshProUGUI numberText;

    internal void SetColor(int paintColor)
    {
        bucketImage.color = Gameplay.ColorPalette[paintColor];
    }
    public void SetNumber(int number)
    {
        numberText.text = number.ToString();
    }
}
