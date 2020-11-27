using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.Xml;

public class DatosXML
{

    [XmlAttribute("Nombre")]
    public string nombre;

    [XmlElement("Tiempo")]
    public int tiempo;

    [XmlElement("Puntaje")]
    public int puntaje;

}
