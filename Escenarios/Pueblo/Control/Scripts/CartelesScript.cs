using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Código hecho por Gabriel Jeannot - 2185887
public class CartelesScript : MonoBehaviour
{
    public GameObject CartelEspecifico;
    public GameObject GUIMostrar;
    public TMP_Text Texto;
    

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            if (hit.transform != null)
            {

                    Rigidbody rb;

                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        PopUp();

                    }
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        PopOff();
                    }


                }
        }

        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    public void PopUp()
    {
        GUIMostrar.SetActive(true);
    }

    public void PopOff()
    {
        GUIMostrar.SetActive(false);
    }

}
