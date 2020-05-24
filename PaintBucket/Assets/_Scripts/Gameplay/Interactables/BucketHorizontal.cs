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
        foreach (var cell in AffectedCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }

        base.OnPress();
    }

    public override void SetAffectedCells()
    {
        AffectedCells = RiddleGenerator.instance.currentRiddleGeneration.riddleCells
            .Where(x => x.coordinates.y == cell.coordinates.y).ToList<Cell>();
    }
}
