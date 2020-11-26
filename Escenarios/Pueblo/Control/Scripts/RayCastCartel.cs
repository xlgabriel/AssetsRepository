using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Código hecho por Gabriel Jeannot - 2185887
public class RayCastCartel : MonoBehaviour
{
    
    void OnDrawGizmos()
    {
        float distanciaMax = 100000f;
        RaycastHit hit;

        bool Detecta = Physics.Raycast(transform.position, transform.forward, out hit, distanciaMax);
        if (Detecta)
        {
            Gizmos.color = Color.red;
            Debug.DrawLine(transform.position, transform.forward * distanciaMax, Color.red);
        }
        else
        {
            Gizmos.color = Color.green;
            Debug.DrawLine(transform.position, transform.forward * distanciaMax, Color.green);
        }
    }

}
