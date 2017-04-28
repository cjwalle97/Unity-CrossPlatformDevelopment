using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class KnowledgeBehaviour : MonoBehaviour
{

    public int knowledge;
    public Text level;

    void Start()
    {
        knowledge = 1;
    }

    void Update()
    {
        string text = "Knowledge Level: " + knowledge;
        level.text = text + Environment.NewLine;
    }
}