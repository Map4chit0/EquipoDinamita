using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContraReloj : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    protected float timer = 120;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        timer -= Time.deltaTime;
        text.text = "Time: " + timer.ToString("f0");

        if (timer <=0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
