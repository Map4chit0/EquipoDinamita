using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void PauseButton()
    {
        pauseMenu.SetActive(true); //con esto veremos el men� de pausa
        Time.timeScale= 0; //detendr� el juego
    }

    public void PlayButton ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale= 1; //con esto el tiempo del juego transcurrir� normal
    }
}
