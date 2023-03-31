using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //En caso de que el botón se fusione con el cambio de escena
using UnityEngine.EventSystems; 

public class ButtonSoundManager : MonoBehaviour, IPointerEnterHandler
{

    public AudioSource audioSource;
    public AudioClip sonidoOver;
    public AudioClip sonidoClic;
    public float volumenOver = 1.0f;
    public float volumenClic = 1.0f;
    public string escenaNom;

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(sonidoOver, volumenOver);
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(sonidoClic, volumenClic);
    }
}
