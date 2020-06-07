using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : SerializedMonoBehaviour
{
    [HideInInspector]
    public Vector2Int coordinates;
    public CellGraphic cellGraphic;
    public CellType cellType;

    public GameObject cellGraphicNew;

    [SerializeField]
    //public Bucket bucketInCell { get; private set; }
    public Bucket bucketInCell { get; private set; }


    //public void SetInteractable(Bucket _bucketType)
    public void SetInteractable(Bucket _bucketType)
    {
        bucketInCell = _bucketType;
        bucketInCell.cell = this;
        bucketInCell.button.onClick.AddListener(delegate { bucketInCell.OnPress(); });
        bucketInCell.bucketGraphics.SetColor(bucketInCell.paintColor);
        cellType = CellType.Interactable;
    }
    
}
public enum CellType
{
    Empty = 0, //Unknown type
    Paintable = 1, //Available to be colored
    Interactable = 2, //Can be pressed (huiyovina)
}
