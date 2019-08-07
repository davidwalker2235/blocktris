using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    private int[] blocks= new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 , 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 , 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 , 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    // Start is called before the first frame update
    void Start()
    {
        float positionX = -0.956f;
        float positionY = 1.5313f;
        int column = 1;
        foreach (var elem in blocks)
        {
            int randomNumber = Random.Range(1,4);
            switch (randomNumber)
            {
                case 1:
                    generateBlock("RedBlock", new Vector3(positionX,positionY,0));
                    break;
                case 2:
                    generateBlock("BlueBlock", new Vector3(positionX, positionY, 0));
                    break;
                case 3:
                    generateBlock("GreenBlock", new Vector3(positionX, positionY, 0));
                    break;
                case 4:
                    generateBlock("YellowBlock", new Vector3(positionX, positionY, 0));
                    break;
                default:
                    break;
            }
            if((column % 7) == 0) {
                positionX = -0.956f;
                positionY = positionY - 0.1883f;
            } else
            {
                positionX = positionX + 0.335f;
            }
            column++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void generateBlock(string block, Vector3 position)
    {
        GameObject redBlock = GameObject.FindWithTag(block);
        BlockPrefab.InstantiateBlock(redBlock, position);
    }
}
