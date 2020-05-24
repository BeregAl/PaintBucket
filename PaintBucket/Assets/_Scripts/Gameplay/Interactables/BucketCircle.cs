using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BucketCircle : Bucket
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
        AffectedCells = RiddleGenerator.instance.currentRiddleGeneration.riddleCells
            .Where(x => Mathf.Abs(x.coordinates.y - cell.coordinates.y) <= 1 && 
                        Mathf.Abs(x.coordinates.x - cell.coordinates.x) <= 1)
                        .ToList<Cell>();
    }
}
