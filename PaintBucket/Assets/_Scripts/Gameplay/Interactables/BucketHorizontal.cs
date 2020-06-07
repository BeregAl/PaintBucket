using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;

public class BucketHorizontal : Bucket
{
    private GameObject _mask;

    //public Cell cell = null;
    //public Color32 paintColor;

    public override void OnPress()
    {
        Gameplay._frontSortingOrder += 2;

        _mask = Instantiate(Gameplay.instance.mask, Gameplay.instance.gridOfMask.transform);
        _mask.GetComponent<SpriteMask>().frontSortingOrder = Gameplay._frontSortingOrder;

        SetMaskPosition();

        Gameplay._sortingOrder--;
        Debug.Log(Gameplay._sortingOrder);

        foreach (var cell in AffectedCells)
        {
            cell.cellGraphicNew.GetComponent<SpriteRenderer>().color = Gameplay.ColorPalette[paintColor];
            cell.cellGraphicNew.GetComponent<SpriteRenderer>().sortingOrder = Gameplay._frontSortingOrder - 1;
            //cell.cellGraphic.SetColorFromPalette(paintColor, CellAnimationType.ToColor);
        }

        base.OnPress();



        _mask.transform.DOScale(500, 1f).OnComplete(SetGraphic);
    }

    public override void SetAffectedCells()
    {
        AffectedCells = RiddleGenerator.instance.currentRiddleGeneration.riddleCells
            .Where(x => x.coordinates.y == cell.coordinates.y).ToList<Cell>();
    }

    public void SetGraphic()
    {
        foreach (var cell in AffectedCells)
        {
            cell.cellGraphic.SetColorFromPalette(paintColor, CellAnimationType.None);

            cell.cellGraphicNew.GetComponent<SpriteRenderer>().sortingOrder = 500;


            Destroy(_mask);
            //_mask.transform.localScale = new Vector3(0, 0, 50);
        }
    }

    public void SetMaskPosition()
    {
        //Gameplay.instance.mask.GetComponent<RectTransform>().anchoredPosition = new Vector3(cell.transform.parent.GetComponent<RectTransform>().anchoredPosition.x, cell.transform.parent.GetComponent<RectTransform>().anchoredPosition.y, 0);
        _mask.GetComponent<RectTransform>().anchoredPosition = new Vector3(cell.transform.parent.GetComponent<RectTransform>().anchoredPosition.x, cell.transform.parent.GetComponent<RectTransform>().anchoredPosition.y, 0);
    }
}
