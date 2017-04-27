using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class KindnessBehaviour : MonoBehaviour {

    public int kindness;
    public Text level;

	void Start () {
        kindness = 1;
	}
	
	void Update () {
        string text = "Kindness Level: " + kindness;
        level.text = text + Environment.NewLine;
    }
}
