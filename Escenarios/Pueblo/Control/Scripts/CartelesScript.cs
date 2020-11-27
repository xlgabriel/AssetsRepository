using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Código hecho por Gabriel Jeannot - 2185887
public class CartelesScript : MonoBehaviour
{
    
    

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
                        ZoomToObject();

                    }
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        
                    }


                }
        }

        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    public void ZoomToObject()
    {
        
    }

   

}
