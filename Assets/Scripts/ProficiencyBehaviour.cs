using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyBehaviour : MonoBehaviour {

    public int proficiency;
    public Text level;

    void Start()
    {
        proficiency = 1;
    }

    void Update()
    {
        string text = "Proficiency Level: " + proficiency;
        level.text = text + Environment.NewLine;
    }
}
