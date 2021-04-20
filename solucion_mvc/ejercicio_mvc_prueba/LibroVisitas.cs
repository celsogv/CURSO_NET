using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ejercicio_mvc_prueba
{
    public class LibroVisitas
    {



        public void Grabar(string nombre, string comentarios)

        {


            StreamWriter archivo = new StreamWriter(HostingEnvironnment MapPath("~") + "/App_Data/dfatos.txt", true);
            archivo.WriteLine("Nombre:" + nombre "<br>Comentarios:" + comentarios + "<hr>");
            archivo.Close();



        }


        public string Leer()
        {

            DtreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~")) + "/App_Data/datos.txt");
            string todo = archovo.ReadToEnd();
            archivo.Close();
            return todo;




        }
    }
}