using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Main : MonoBehaviour
{
    private float time = 0.0f;
    private float newLineTime = 0.0f;
    public float interpolationPeriod = 3f;
    public float newLineinterpolationPeriod = 0.3f;
    private int[] blocks= new int[] {0,0,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,0};

    // Start is called before the first frame update
    void Start()
    {
        createBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        moveBlocksToDown();
    }

    private void createBlocks()
    {
        float positionX = -1.0362f;
        float positionY = 1.84f;
        int column = 1;
        foreach (var elem in blocks)
        {
            if (elem == 1) {
                generateBlock(getRandomBlock(), new Vector3(positionX, positionY, 0));
            }

            if ((column % 11) == 0)
            {
                positionX = -1.0362f;
                positionY = positionY - 0.1247f;
            }
            else
            {
                positionX = positionX + 0.2102f;
            }
            column++;
        }
    }

    private void generateNewLineOfBlocks()
    {
        float positionX = -1.0362f;
        float positionY = 1.84f;
        newLineTime += Time.deltaTime;

        newLineTime = newLineTime - newLineinterpolationPeriod;
        for (int i = 0; i < 11; i++)
        {
            generateBlock(getRandomBlock(), new Vector3(positionX, positionY, 0));
            positionX = positionX + 0.2102f;
        }
    }

    private void generateBlock(string block, Vector3 position)
    {
        GameObject cloneBlock = GameObject.FindWithTag(block);
        BlockPrefab.InstantiateBlock(cloneBlock, position);
    }

    private void moveBlocksToDown()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = time - interpolationPeriod;
            moveBlocks();
            generateNewLineOfBlocks();
        }
    }

    private string getRandomBlock()
    {
        int randomNumber = Random.Range(1, 4);
        switch (randomNumber)
        {
            case 1:
                return "RedBlock";
            case 2:
                return "BlueBlock";
            case 3:
                return "GreenBlock";
            case 4:
                return "YellowBlock";
            default:
                return null;
        }
    }

    private void moveBlocks()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("RedBlock");
        GameObject[] blueBlock = GameObject.FindGameObjectsWithTag("BlueBlock");
        GameObject[] greenBlock = GameObject.FindGameObjectsWithTag("GreenBlock");
        GameObject[] yellowBlock = GameObject.FindGameObjectsWithTag("YellowBlock");

        blocks = blocks.Concat(blueBlock).ToArray();
        blocks = blocks.Concat(greenBlock).ToArray();
        blocks = blocks.Concat(yellowBlock).ToArray();
        foreach (var item in blocks)
        {
            Vector3 position = item.transform.position;
            item.transform.position = new Vector3(position.x, position.y - 0.1247f, 0);
        }
    }
}
