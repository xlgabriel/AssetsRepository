using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaTrigger : MonoBehaviour
{
    public int NumeroEscena;


    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(NumeroEscena);
    }
}
