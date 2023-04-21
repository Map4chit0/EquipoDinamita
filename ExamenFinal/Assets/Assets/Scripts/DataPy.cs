using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataPy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Record;
    [SerializeField] private TextMeshProUGUI Record2;
    void Start()
    {
        Record.text = "Max. Score en Classic: " + PlayerPrefs.GetInt("Record", 0).ToString();
        Record2.text = "Max. Score en Time Trial: " + PlayerPrefs.GetInt("Record2", 0).ToString();
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            BorrarDatos();
        }
        if (Input.GetKey(KeyCode.E))
        {
            BorrarDatos2();
        }
    }
    // Update is called once per frame
    public void BorrarDatos()
    {
        //este void esta vinculado a un boton que borra el record 
        //esto con la finalidad de demostrar y comprobar el funcionamiento correcto del puntaje maximo
        PlayerPrefs.DeleteKey("Record");
        Record.text = "0";
    }
    public void BorrarDatos2()
    {
        //este void esta vinculado a un boton que borra el record 
        //esto con la finalidad de demostrar y comprobar el funcionamiento correcto del puntaje maximo
        PlayerPrefs.DeleteKey("Record2");
        Record.text = "0";
    }
}
