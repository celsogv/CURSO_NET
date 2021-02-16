using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Persona
    {




        protected string nombre;
        protected int edad;
        protected string apellidos;


        public void Inicializar()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);


        }


        public void Imprimir()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("edad:");
            Console.WriteLine(edad);




        }



        public void EsMayorEdad()
        {

            if (edad >= 18)
            {


                Console.Write("Es mayor de edad");
            }


            else
            {

                Console.Write("No es mayor de edad");




            }

            Console.ReadKey();





        }

        public void Saludar()
        {
            Console.WriteLine("Hola: soy ");


        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;



        }

        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;



        }


        public void SetEdad(int edad)
        {
            this.edad = edad;



        }



    }
}
