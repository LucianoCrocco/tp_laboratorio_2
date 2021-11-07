using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using Excepciones;


namespace ArchivosYSerializacion
{
    public class SerializacionXML<T> : IArchivo<T>
    {
        XmlTextWriter escribirObjeto;
        XmlSerializer serializarObjeto;
        XmlTextReader leerObjeto;


        public void Guardar(T dato, string path, bool append)
        {
            try
            {
                escribirObjeto = new XmlTextWriter(path, System.Text.Encoding.UTF8);
                serializarObjeto = new XmlSerializer(typeof(T));
                serializarObjeto.Serialize(escribirObjeto, dato);
                escribirObjeto.Close();
            }
            catch (Exception ex)
            {
                throw new GuardarSerializacionException("Error al querer guardar el archivo XML", ex);
            }
        }

        public T Leer(string path)
        {
            T generico;
           
            try
            {
                leerObjeto = new XmlTextReader(path);
                serializarObjeto = new XmlSerializer(typeof(T));
                generico = (T)serializarObjeto.Deserialize(leerObjeto);
                leerObjeto.Close();
            }
            catch (Exception ex)
            {
                throw new CargarSerializacionException("Error al querer cargar el archivo XML",ex);
            }
            return generico;
        }
    }
}
