using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{

    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 0;

    

    void Update()
    {

        if (isTakingTime == false)
        {
            StartCoroutine(AddSecond());
        }


    }

    IEnumerator AddSecond()
    {
        isTakingTime = true;
        theSeconds += 1;
        
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }

}