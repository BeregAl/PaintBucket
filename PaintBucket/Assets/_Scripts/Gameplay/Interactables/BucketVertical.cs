using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BucketVertical : Bucket
{


    public override void OnPress()
    {
        foreach (var cell in AffectedCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }
        base.OnPress();
    }
    public override void SetAffectedCells()
    {
        AffectedCells = RiddleGenerator.instance.currentRiddleGeneration.riddleCells.Where(x => x.coordinates.x == cell.coordinates.x).ToList<Cell>();
    }
}
