using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject block = GameObject.FindWithTag("RedBlock");
        BlockPrefab.InstantiateBlock(block, new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
