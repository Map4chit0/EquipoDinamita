using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void PauseButton()
    {
        pauseMenu.SetActive(true); //con esto veremos el menú de pausa
        Time.timeScale= 0; //detendrá el juego
    }

    public void PlayButton ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale= 1; //con esto el tiempo del juego transcurrirá normal
    }
}
