using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A special building that holds a static reference so it can be found by other scripts easily (e.g. for Units to go back
/// to it)
/// </summary>
public class Base : Building
{ 
    public static Base Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}
