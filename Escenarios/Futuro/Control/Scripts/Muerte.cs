
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour
{

    public GameObject Personaje;
    public GameObject CuboMuerte;

    

    void OnTriggerEnter()
    {
        float YPer = Personaje.transform.position.y;
        float YCub = CuboMuerte.transform.position.y;

        if (YPer < YCub)
        {
            Puntaje.currentScore = 0;
            SceneManager.LoadScene(3);
        }
    
    }

}