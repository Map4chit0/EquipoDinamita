using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public GameObject blockPref;
    public List<Block> blocks;
    List<int[,]> movements;
    

    int currentMove = 0;

    // Start is called before the first frame update
    void Start()
    {
        movements = Pieces.GetPiece();

        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                if (movements[0][x, y] == 1)
                {
                    Block b = Instantiate(blockPref, transform).GetComponent<Block>();
                    b.transform.localPosition = new Vector2(x, -y);
                    blocks.Add(b);
                }
            }
        }
    }

    internal void Move(int px, int py)
    {
        transform.position += new Vector3(px, py);

        foreach(Block b in blocks)
        {
            if (b.x < 0 || b.x > 15)
                Move(-px, -py);
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           Time.timeScale = 20;

            
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
          Time.timeScale = 1;
         

        } */
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(1, 0);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Trun();
        }
    }

    private void Trun()
    {
        currentMove = (int)Mathf.Repeat(++currentMove, movements.Count);
        int i = 0;
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                if (movements[currentMove][x, y] == 1)
                {
                    blocks[i].transform.localPosition = new Vector2(x, -y);
                    i++;
                }
            }
        }
    }
}
