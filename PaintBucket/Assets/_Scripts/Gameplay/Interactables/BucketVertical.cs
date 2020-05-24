using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BucketVertical : Bucket
{
    /*public BucketVertical(Bucket bucket) : base(bucket)
    {
    }*/
    public BucketVertical(Cell cell, Color32 paintColor) : base(cell, paintColor)
    {

    }

    public override void OnPress()
    {
        var _targetCells = Gameplay.currentRiddle.riddleCells.Where(x => x.coordinates.x == cell.coordinates.x);
        foreach (var cell in _targetCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }
    }
}
