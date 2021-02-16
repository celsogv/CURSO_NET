using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Estudiante : Persona
    {



        public void Estudiar()
        {


            Console.WriteLine(nombre + " " + apellidos + " " + edad + " estoy estudiando");

        }


        public void VerEdad()
        {



            Console.WriteLine("Mi edad es: " + edad + "años");

        }
    }
}
