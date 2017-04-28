using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour {

    public GameObject GridBlock;
    public List<GameObject> Blocks;

    public void MakeGrid() {
        
        int i = 0;
        for (; i <= 3; i++)
        {
            for(int j = 0; j <= 3; j++)
            {
                Vector3 Position = new Vector3(i, 0, j);
                var go = Instantiate<GameObject>(GridBlock, Position, transform.rotation);
                Blocks.Add(go);
            }
        }    
    }

    [ContextMenu ("Create")]
    void Create()
    {
        MakeGrid();
    }

  

    void Start()
    {
        MakeGrid();
    }

    void Update()
    {

    }
}
