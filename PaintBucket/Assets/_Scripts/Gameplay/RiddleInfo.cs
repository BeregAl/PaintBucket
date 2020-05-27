using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleInfo
{
    //All Cells
    public List<Cell> riddleCells = new List<Cell>();
    public List<Bucket> riddleBuckets = new List<Bucket>();

    //Max sizeX and SizeY of riddle
    public Vector2Int riddleBounds;
}
