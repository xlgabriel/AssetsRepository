using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gemas : MonoBehaviour
{

    public GameObject scoreBox;
    public AudioSource collectSound;
    public int ValorPuntaje;

    void OnTriggerEnter()
    {
        Puntaje.currentScore += ValorPuntaje;
        collectSound.Play();
        Destroy(gameObject);
    }

}