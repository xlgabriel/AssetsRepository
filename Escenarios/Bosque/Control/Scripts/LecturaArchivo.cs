using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class LecturaArchivo : MonoBehaviour
{
    string pathFile;
    public Vector3[] posiciones;

    // Start is called before the first frame update
    void Start()
    {
        pathFile = "Assets/Escenarios/Bosque/Control/coordenadas.txt";
        lectura();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lectura()
    {
        string[] fileline = File.ReadAllLines(pathFile);
        posiciones = new Vector3[fileline.Length];

        for(int i=0; i< fileline.Length; i++)
        {

            string[] partesNuevas = fileline[i].Split("/"[0]);
            float x = float.Parse(partesNuevas[0]);
            float y = float.Parse(partesNuevas[1]);
            float z = float.Parse(partesNuevas[2]);
            posiciones[i] = new Vector3(x, y, z);
        }

        for(int i=0; i < posiciones.Length; i++)
        {
            Debug.Log("Nuevo árbol ubicado: " + posiciones[i].ToString());
        }

    }

}
