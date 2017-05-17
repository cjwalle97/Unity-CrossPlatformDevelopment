using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PlayerTextBehaviour : MonoBehaviour {
    public Text texttoChange;

    void ChangeText()
    {
        texttoChange.text = FindObjectOfType<TestPlayerBehaviour>().ThePlayer.Health.ToString();
    }
}
