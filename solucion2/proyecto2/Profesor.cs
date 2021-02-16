using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Profesor : Persona
    {



        public void Explicar()
        {


            Console.WriteLine(nombre + " " + apellidos + " " +  edad + " Estoy explicando");

        }
    }
}
