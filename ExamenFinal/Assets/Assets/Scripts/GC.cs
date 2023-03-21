using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GC : MonoBehaviour
{
    public GameObject prefabPiece;
    Piece currentPiece;
    public TextMeshProUGUI T;
    private float score = 60;

    Block[,] stageBlocks = new Block[16,32];

    // Start is called before the first frame update
    void Start()
    {
        NewPiece();
        
    }

    void Update()
    {
        score -= Time.deltaTime;
        T.text =  "Tiempo: " + score.ToString("f0");
    }

    private void NewPiece()
    {
        currentPiece = Instantiate(prefabPiece, transform).GetComponent<Piece>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentPiece.Move(0, -1);

        foreach(Block b in currentPiece.blocks)
        {
            if (b.y < 0 || stageBlocks[b.x, b.y] != null)
            {
                currentPiece.Move(0, 1);
                Down();
                break;
            }
        }
    }

    private void Down()
    {
        foreach (Block b in currentPiece.blocks)
        {
            stageBlocks[b.x, b.y] = b;
        }

        IsLine();

        currentPiece.enabled = false;
        NewPiece();

    }

    private void IsLine()
    {
        for (int y = 0; y < 32; y++)
        {
            bool line = true;
            for (int x = 0; x < 16; x++)
            {
                if (stageBlocks[x, y] == null)
                {
                    line = false;
                    break;
                }
            }
            if (line)
            {
                RemoveLine(y);
                y--;
                score = score + 30;
            }

        }
    }

    private void RemoveLine(int py)
    {
        for (int x = 0; x < 16; x++)
        {
            DestroyImmediate(stageBlocks[x, py].gameObject);//TODO: Fixed!
        }

        for (int y = py + 1; y < 32; y++)
        {
            for (int x = 0; x < 16; x++)
            {
                Block b = stageBlocks[x, y];
                if (b!= null)
                {
                    stageBlocks[x, y] = null;
                    b.transform.position += Vector3.down;
                    stageBlocks[b.x, b.y] = b;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 32; y++)
            {
                Gizmos.DrawWireCube(new Vector2(x - 8, y - 16), Vector3.one);
            }
        }
    }
}
