using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Contador : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    protected float timer = 00;
    float minu = 00;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 59)
        {
            timer = 0;
            minu += 01;
        }
        text.text= "Time: " + minu.ToString("f0") + " : "+ timer.ToString("f0");
    }
}
