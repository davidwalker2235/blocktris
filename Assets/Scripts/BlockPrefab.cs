using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPrefab : MonoBehaviour
{
    GameObject newBlock;
    // Start is called before the first frame update
    public static void InstantiateBlock(GameObject block, Vector3 position)
    {
        Instantiate(block, position, Quaternion.identity);
    }
}
