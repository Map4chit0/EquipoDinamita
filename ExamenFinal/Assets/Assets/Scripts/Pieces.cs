using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    internal static List<int[,]> GetPiece()
    {
        int num = Random.Range(0, 5);
        if (num == 0)
        {
            List<int[,]> piece = new List<int[,]>();

            piece.Add(new int[,]{
                { 1,0,0,0},
                { 1,0,0,0},
                { 1,0,0,0},
                { 1,0,0,0},
            });

            piece.Add(new int[,]{
                { 1,1,1,1},
                { 0,0,0,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });
            return piece;
        }

        if (num == 1)
        {
            List<int[,]> piece = new List<int[,]>();

            piece.Add(new int[,]{
                { 1,0,0,0},
                { 1,0,0,0},
                { 1,1,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 1,1,1,0},
                { 1,0,0,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 1,1,0,0},
                { 0,1,0,0},
                { 0,1,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 0,0,1,0},
                { 1,1,1,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            return piece;
        }

        if (num == 2)
        {
            List<int[,]> piece = new List<int[,]>();

            piece.Add(new int[,]{
                { 1,0,0,0},
                { 1,1,0,0},
                { 1,0,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 1,1,1,0},
                { 0,1,0,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 0,1,0,0},
                { 1,1,0,0},
                { 0,1,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 0,1,0,0},
                { 1,1,1,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            return piece;
        }

        if (num == 3)
        {
            List<int[,]> piece = new List<int[,]>();

            piece.Add(new int[,]{
                { 1,1,0,0},
                { 0,1,1,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 0,1,0,0},
                { 1,1,0,0},
                { 1,0,0,0},
                { 0,0,0,0},
            });
            piece.Add(new int[,]{
                { 0,1,1,0},
                { 1,1,0,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });

            piece.Add(new int[,]{
                { 1,0,0,0},
                { 1,1,0,0},
                { 0,1,0,0},
                { 0,0,0,0},
            });
            return piece;
        }


        if (num == 4)
        {
            List<int[,]> piece = new List<int[,]>();

            piece.Add(new int[,]{
                { 1,1,0,0},
                { 1,1,0,0},
                { 0,0,0,0},
                { 0,0,0,0},
            });
            return piece;
        }
            return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
