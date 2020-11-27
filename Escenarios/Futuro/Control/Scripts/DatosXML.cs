using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

public class DatosXML
{

    public static DatosXML ins;

    void Awake()
    {
        ins = this;
    }

}

[System.Serializable]
public class ItemEntry
{
    public string nombreJugador;
    public int puntajefinal;
    public int tiemporecorrido;
}

[System.Serializable]
public class ItemDataBase
{
   
}
