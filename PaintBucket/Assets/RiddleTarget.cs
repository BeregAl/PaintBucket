using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighlightTargetCells()
    {
        Dictionary<Cell, int> _affectedCells = new Dictionary<Cell, int>();
        for (int i = Gameplay.RiddleSolution.Count-1; i >=0 ; i--)
        {
            var bucket = Gameplay.RiddleSolution[i];
            foreach (var cell in bucket.AffectedCells)
            {
                if (_affectedCells.ContainsKey(cell) == false)
                {
                    _affectedCells.Add(cell, bucket.paintColor);
                }
            }
        }

        foreach (var cell in _affectedCells)
        {
            cell.Key.cellGraphic.SetColorFromPalette(cell.Value, CellAnimationType.ToColorAndBack);
        }
    }
    
}
