using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GCdos : MonoBehaviour
{
    public GameObject prefabPiece;
    Piece currentPiece;
    public TextMeshProUGUI T;


    private float score = 60;
    private float Vel = 0;
    private float maxTime = 1;
    private bool canMove = true;

    Block[,] stageBlocks = new Block[16, 32];


    //para puntaje:
    [SerializeField] private TMP_Text textoPuntaje;
    private int puntaje = 0;


    // Start is called before the first frame update
    void Start()
    {
        NewPiece(); //ejecuta función NewPiece
        textoPuntaje.text = "Score: " + puntaje; //para puntahe
        T.text = "Tiempo: " + score.ToString("f0");

    }

    void Update()
    {
         score -= Time.deltaTime;
         T.text =  "Tiempo: " + score.ToString("f0");
        if (score <= 0)
        {
            SceneManager.LoadScene(4);
        }
        Vel -= Time.deltaTime; //velocidad.
        foreach (Block b in currentPiece.blocks)
        {
            //Debug.Log(b.y, b.gameObject);
            if (b.y < 0 || stageBlocks[b.x, b.y] != null)
            {
                currentPiece.Move(0, 1);
                Debug.Log("bloquea");
                canMove = false;
                Down();
                break;
            }
            else
            {
                canMove = true;
            }
        }

        if (Vel <= 0)
        {
            //Debug.Log(currentPiece.blocks.Count);

            if (canMove)
            {
                currentPiece.Move(0, -1);
            }

            Vel = maxTime;

        }

        // Check Horizontal
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentPiece.Move(-1, 0);
            foreach (Block b in currentPiece.blocks)
            {
                //Debug.Log(b.y, b.gameObject);
                if (b.y <= -5 || stageBlocks[b.x, b.y] != null)
                {

                    currentPiece.Move(1, 0);
                    Debug.Log("bloqueo Dere");
                }

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentPiece.Move(1, 0);
            foreach (Block b in currentPiece.blocks)
            {
                //Debug.Log(b.y, b.gameObject);
                if (b.y <= -5 || stageBlocks[b.x, b.y] != null)
                {

                    currentPiece.Move(-1, 0);
                    Debug.Log("bloqueo Izq");

                }

            }

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //currentPiece.Move(0, -1); 
            if (Vel > 0.02f)
            {
                Vel = 0;
            }
            maxTime = 0.02f;
        }
        else
        {
            maxTime = 1;
        }
    }

    private void NewPiece()
    {
        currentPiece = Instantiate(prefabPiece, transform).GetComponent<Piece>();
    }


    private void Down()
    {
        foreach (Block b in currentPiece.blocks)
        {
            // Debug.Log(b.x + ", " + b.y, b.gameObject);
            stageBlocks[b.x, b.y] = b;
        }

        IsLine();

        currentPiece.enabled = false;
        currentPiece = null;
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
                //puntaje
                puntaje = puntaje + 100;
                textoPuntaje.text = "Score: " + puntaje;
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
                if (b != null)
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
    /* private void GO ()
     {
             foreach (Block b in currentPiece.blocks)
         {
             if (b.y > 2 )
             {
                 Debug.Log("Perdiste");
             }
         }
     }*/
}
