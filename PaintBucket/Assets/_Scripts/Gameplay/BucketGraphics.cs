using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BucketGraphics : MonoBehaviour
{
    [SerializeField]
    private Image bucketImage;

    internal void SetColor(Color32 paintColor)
    {
        bucketImage.color = paintColor;
    }
}
