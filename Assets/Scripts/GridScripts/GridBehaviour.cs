using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour {

    public GameObject gridblocks;


    public void MakeGrid() {
        List<Vector3> Grid = new List<Vector3>();
        int i = 0;
        int j = 0;
        for (; i <= 3; i++)
        {
            for(; j <= 3; j++)
            {
                Vector3 Position = new Vector3(i, 0, j);
                Grid.Add(Position);
            }
        }
    }
}
