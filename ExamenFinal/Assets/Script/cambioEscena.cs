using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void JuegoNormal()
    {
        SceneManager.LoadScene(0);
    }

    public void ContraReloj ()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu ()
    {
        SceneManager.LoadScene(1);
    }


}
