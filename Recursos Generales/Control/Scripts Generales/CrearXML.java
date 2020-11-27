/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.LinkedList;
import java.util.List;
import org.jdom2.Attribute;
import org.jdom2.Document;
import org.jdom2.Element;
import org.jdom2.JDOMException;
import org.jdom2.input.SAXBuilder;
import org.jdom2.output.Format;
import org.jdom2.output.XMLOutputter;

/**
 *
 * @author dacastro
 */
public class CrearXML {
    //Creacion del Archivo XML
    public void crearArchivoXML(LinkedList<EmpleadoContrato> ec) {
        try {
            // se intenta crear el nombre del elemento y el documento donde almacenar los datos
            Element empleadoContrato = new Element("EmpleadoContrato");
            Document doc = new Document(empleadoContrato);
            // como es una lista, se debe recorrer para alamcenar los datos por cada posicion de ell
            for (int i = 0; i < ec.size(); i++) {
                Element empleado = new Element("empleado"); // creas un element que es como un nombre de carpeta para cada pos
                empleado.setAttribute(new Attribute("id", ec.get(i).getId()));  // añades una Id a la carpeta de cada pos
                empleado.addContent(new Element("nombre").setText(ec.get(i).getNombre()));// y empiezas a añadir datos dentro de la carpeta
                empleado.addContent(new Element("telefono").setText(ec.get(i).getTele()));
                empleado.addContent(new Element("numContrato").setText(ec.get(i).getNumContrato()));
                empleado.addContent(new Element("actividad").setText(ec.get(i).getActividad()));
                doc.getRootElement().addContent(empleado); // una vez tienes los datos almacenados en las carpetas, lo alojas en el Docmento creado inicialmente
            }
            // new XMLOutputter().output(doc, System.out);
            XMLOutputter xmlOutput = new XMLOutputter();  //mas metodos reservados para alojamiento de datos en XML

            // display nice nice
            xmlOutput.setFormat(Format.getPrettyFormat()); // añade formatos
            xmlOutput.output(doc, new FileWriter("empleadoC.xml")); //aqui se pone el nombre del archivo XML a guardar

            System.out.println("File Saved!"); // en consola le dices que funcionó
        } catch (IOException io) {
            System.out.println(io.getMessage()); // en caso de error avisar por favor
        }
    }

    public void leerArchivoXML() { // ahora la Lectura de archivos
        SAXBuilder builder = new SAXBuilder(); // un reservado para decirle al Java, Hey, es un Xml para leer
        File xmlFile = new File("empleadoC.xml"); // pides el nombre del XML

        try {
            //Se crea el documento a traves del archivo
            Document document = (Document) builder.build(xmlFile);

            //Se obtiene la raiz 'tables'
            Element rootNode = document.getRootElement();

            //Se obtiene la lista de hijos de la raiz 'tables'
            List list = rootNode.getChildren("empleado");

            //Se recorre la lista de hijos de 'tables'
            for (int i = 0; i < list.size(); i++) {
                Element tabla = (Element) list.get(i);
                String nombre = tabla.getChildText("nombre");
                System.out.println("nombre: " + nombre);
                String id = tabla.getAttributeValue("id");
                System.out.println("id: " + id);
                String telefono = tabla.getChildText("telefono");
                System.out.println("telefono: " + telefono);
                String numContrato = tabla.getChildText("numContrato");
                System.out.println("numContrato: " + numContrato);
                String actividad = tabla.getChildText("actividad");
                System.out.println("actividad: " + actividad);

            }
        } catch (IOException io) {
            System.out.println(io.getMessage());
        } catch (JDOMException jdomex) {
            System.out.println(jdomex.getMessage());
        }
    }

}
