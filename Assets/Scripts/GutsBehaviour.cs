using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GutsBehaviour: MonoBehaviour
{

    public int guts;
    public Text level;

    void Start()
    {
        guts = 1;
    }

    void Update()
    {
        string text = "Guts Level: " + guts;
        level.text = text + Environment.NewLine;
    }
}