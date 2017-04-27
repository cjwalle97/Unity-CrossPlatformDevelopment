using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CharmBehaviour : MonoBehaviour {

    public int charm;
    public Text level;

    void Start()
    {
        charm = 1;
    }

    void Update()
    {
        string text = "Charm Level: " + charm;
        level.text = text + Environment.NewLine;
    }
}
