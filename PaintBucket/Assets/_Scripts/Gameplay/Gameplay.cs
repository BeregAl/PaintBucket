using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gameplay : Singleton<Gameplay>
{
    public const float ANIMATION_TIME = 0.3f;

    public static RiddleInfo currentRiddle;
    public static int currentRiddleStep = 1;

    public static Dictionary<int, Color32> ColorPalette = new Dictionary<int, Color32>();
    public static List<Bucket> RiddleSolution = new List<Bucket>();
    



    private void Awake()
    {
        RiddleGenerator.instance.onRiddleGenerated += OnRiddleGenerated;        
    }
    // Start is called before the first frame update
    void Start()
    {
        RiddleGenerator.instance.GenerateRiddle();

    }

    private void OnRiddleGenerated(RiddleInfo arg0)
    {
        currentRiddle = arg0;
        currentRiddleStep = 1;
        RiddleTarget.CountSolution();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        RiddleGenerator.instance.onRiddleGenerated -= OnRiddleGenerated;
    }

    public static void RiddleSolved()
    {
        Debug.Log("GenerateRiddle");
        RiddleGenerator.instance.GenerateRiddle();
    }
}
