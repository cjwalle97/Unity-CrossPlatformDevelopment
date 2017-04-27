using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KindnessBehaviour : MonoBehaviour {

    public int kindness;
    public string text;

	// Use this for initialization
	void Start () {
        kindness = 1;
	}
	
	// Update is called once per frame
	void Update () {
        text = "Kindness Level: " + kindness;
	}
}
