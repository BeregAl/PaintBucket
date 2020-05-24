using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BucketCircle : Bucket
{
    public override void OnPress()
    {
        var _targetCells = Gameplay.currentRiddle.riddleCells.Where(x => Mathf.Abs( x.coordinates.y - cell.coordinates.y) <=1 && Mathf.Abs(x.coordinates.x - cell.coordinates.x) <=1);
        foreach (var cell in _targetCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }
    }
}
