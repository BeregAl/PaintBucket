using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : Singleton<Gameplay>
{

    public static RiddleInfo currentRiddle;
    public static int currentRiddleStep = 1;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        RiddleGenerator.instance.onRiddleGenerated -= OnRiddleGenerated;
    }
}
