using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bucket : SerializedMonoBehaviour // TODO: generate random bucket type, remove bucket from list, remove all buckets of the same type
{

    public BucketType bucketType;

    private Cell _cell;
    public Cell cell
    {
        get
        {
            return _cell;
        }
        set
        {
            _cell = value;
            SetAffectedCells();
        }
    }

    public int paintColor;
    //public string bucketName;
    public BucketGraphics bucketGraphics;

    public Button button;

    public List<Cell> AffectedCells;

    private int _orderInRiddle = 1;
    public int orderInRiddle
    {
        get
        {
            return _orderInRiddle;
        }
        set
        {
            _orderInRiddle = value;
            bucketGraphics.SetNumber(value);

        }
    }

    public enum BucketType
    {
        Horizontal = 0,
        Vertical = 1,
        Random = 2,
    }
    public virtual void SetAffectedCells()
    {

    }

    /*
    private static Bucket bucket;
    public static Bucket Create(BucketType bucketType, Cell cell, Color32 paintColor, string bucketName = null)
    {
        switch (bucketType)
        {
            case BucketType.Horizontal:

                var bucket = new BucketHorizontal(cell, paintColor);
                //bucket.bucketName = bucketName;
                bucket.cell = cell;
                bucket.paintColor = paintColor;                

                break;
            case BucketType.Vertical:
                break;
            case BucketType.Random:
                break;
            default:
                break;
        }

        return bucket;
    }*/

    /*public BucketHorizontal CreateBucketHorizontal(GameObject _obj, Cell _cell, Color32 _paintColor, string _bucketName = null)
    {
        bucketType = BucketType.Horizontal;

        //BucketHorizontal copy = _obj.AddComponent<BucketHorizontal>();

        //copy.bucketName = _bucketName;
        //copy.cell = _cell;
        //copy.paintColor = _paintColor;

        //buckets.Add(bucket);

        //return copy;
    }*/


    public class BucketBase : MonoBehaviour
    {
        /*public virtual void OnPress()
        {
        }*/
    }

    public virtual void OnPress()
    {
        /*if (orderInRiddle == Gameplay.currentRiddleStep)
        {
            Gameplay.currentRiddleStep++;
            Destroy(this.gameObject);
        }*/
    }

    
}
