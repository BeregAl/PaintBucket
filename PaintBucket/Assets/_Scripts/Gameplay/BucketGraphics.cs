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

    internal void SetColor(Color32 paintColor)
    {
        bucketImage.color = paintColor;
    }
    public void SetNumber(int number)
    {
        numberText.text = number.ToString();
    }
}
