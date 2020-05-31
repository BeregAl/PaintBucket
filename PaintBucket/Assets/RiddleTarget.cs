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

    private static Dictionary<Cell, int> _solutionCells = new Dictionary<Cell, int>();

    public static void CountSolution()
    {
        _solutionCells.Clear();
        for (int i = Gameplay.RiddleSolution.Count-1; i >=0 ; i--)
        {
            var bucket = Gameplay.RiddleSolution[i];
            foreach (var cell in bucket.AffectedCells)
            {
                if (_solutionCells.ContainsKey(cell) == false)
                {
                    _solutionCells.Add(cell, bucket.paintColor);
                }
            }
        }
    }

    public void HighlightTargetCells()
    {
        foreach (var cell in _solutionCells)
        {
            cell.Key.cellGraphic.SetColorFromPalette(cell.Value, CellAnimationType.ToColorAndBack);
        }
    }

    public static void CheckRiddleSolved()
    {
        bool isSolved = true;
        foreach (var cell in _solutionCells)
        {
            if (cell.Key.cellGraphic.currentColor != cell.Value)
            {
                isSolved = false;
                Debug.Log($"Not solved {cell.Key.cellGraphic.currentColor} != {cell.Value} at {cell.Key.coordinates}");
                break;
            }
        }
        if (isSolved)
        {
            Debug.Log("Solved");
            Gameplay.RiddleSolved();
        }
    }
    
}
