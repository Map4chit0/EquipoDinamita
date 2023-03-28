using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Contador : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    protected float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        text.text= "Time: "+ timer.ToString("f0");
    }
}
