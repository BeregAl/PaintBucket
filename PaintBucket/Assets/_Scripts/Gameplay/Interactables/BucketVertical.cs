﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BucketVertical : Bucket
{


    public override void OnPress()
    {
        var _targetCells = Gameplay.currentRiddle.riddleCells.Where(x => x.coordinates.x == cell.coordinates.x);
        foreach (var cell in _targetCells)
        {
            cell.cellGraphic.SetColor(paintColor);
        }
    }
}
