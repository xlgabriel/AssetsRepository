using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CartelesScript : MonoBehaviour
{
    public GameObject PanelImagenPozo;
    public GameObject PanelImagenMercado;
    public GameObject PanelImagenTortura;
    public GameObject PanelImagenCasa;

    public GameObject CartelPozo;
    public GameObject CartelMercado;
    public GameObject CartelTortura;
    public GameObject CartelCasa;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 600.0f))
        {
                if (hit.transform != null)
                {
                    
                    
                    Debug.Log("Nombre: " + hit.collider.gameObject.name);
                    if (CartelCasa.name.Equals(hit.collider.gameObject.name))
                    {
                        PanelImagenCasa.SetActive(true);

                    }

                    if (CartelPozo.name.Equals(hit.collider.gameObject.name))
                    {
                        PanelImagenPozo.SetActive(true);

                    }

                    if (CartelMercado.name.Equals(hit.collider.gameObject.name))
                    {
                        PanelImagenMercado.SetActive(true);

                    }

                    if (CartelTortura.name.Equals(hit.collider.gameObject.name))
                    {
                        PanelImagenTortura.SetActive(true);

                    }

                }
        }

        }
    }

    public void CerrarImagen()
    {
        
        PanelImagenCasa.SetActive(false);
        PanelImagenPozo.SetActive(false);
        PanelImagenTortura.SetActive(false);
        PanelImagenMercado.SetActive(false);

    }
}
