using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BucketHorizontal : Bucket
{

    //public Cell cell = null;
    //public Color32 paintColor;

    public override void OnPress()
    {
        var _targetCells = Gameplay.currentRiddle.riddleCells.Where(x => x.coordinates.y == cell.coordinates.y);
        foreach (var cell in _targetCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }
    }
}
