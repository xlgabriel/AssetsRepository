using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject CuboAparecer;
    public GameObject PanelVictoria;
    public GameObject Jugador;
    public GameObject CamaraVictoria;

    void OnTriggerEnter()
    {
        CuboAparecer.SetActive(true);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        PanelVictoria.SetActive(true);
        CamaraVictoria.SetActive(true);
        Jugador.SetActive(false);
       
    }

}