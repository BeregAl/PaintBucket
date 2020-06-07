using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class BucketCircle : Bucket
{
    private GameObject _mask;
    public override void OnPress()
    {
        Gameplay._frontSortingOrder +=2;

        //foreach (var cell in RiddleGenerator.instance.currentRiddleGeneration.riddleCells)
        //{
        //    cell.cellGraphicNew.GetComponent<SpriteRenderer>().sortingOrder = Gameplay._frontSortingOrder;
        //}

        _mask = Instantiate(Gameplay.instance.mask, Gameplay.instance.gridOfMask.transform);
        _mask.GetComponent<SpriteMask>().frontSortingOrder = Gameplay._frontSortingOrder;

        SetMaskPosition();

        Gameplay._sortingOrder++;
        Debug.Log(Gameplay._sortingOrder);

        foreach (var cell in AffectedCells)
        {
            cell.cellGraphicNew.GetComponent<SpriteRenderer>().color = Gameplay.ColorPalette[paintColor];
            cell.cellGraphicNew.GetComponent<SpriteRenderer>().sortingOrder = Gameplay._frontSortingOrder-1;
        }
        base.OnPress();


        _mask.transform.DOScale(500, 1f).OnComplete(SetGraphic);
    }
    public override void SetAffectedCells()
    {

        AffectedCells = RiddleGenerator.instance.currentRiddleGeneration.riddleCells
            .Where(x => Mathf.Abs(x.coordinates.y - cell.coordinates.y) <= 1 && 
                        Mathf.Abs(x.coordinates.x - cell.coordinates.x) <= 1)
                        .ToList<Cell>();
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
