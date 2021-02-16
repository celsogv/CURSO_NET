using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_metodos
{
    
    class persona
    {
        private string nombre;
        private int edad;
        private Decimal nota;




        public void setNombre(string nombre)
        {
            this.nombre = nombre;


        }
        public void setEdad(int edad)
        {
            this.edad = edad;


        }

        public void setNota(Decimal nota)
        {
            this.nota = nota;


        }



        public void mostrarDator()
        {
            Console.WriteLine("Nombre: " + nombre + " Edad: " + edad.ToString() + " nota: " + nota.ToString());



        }

        public void mostrarCurso()
        {

            Console.WriteLine("El curso es: ");
            if ((nota >= 40) && (nota <= 59))
            {
                Console.WriteLine("B1");



            }

            if ((nota >= 60) && (nota <= 74))
            {
                Console.WriteLine("B2");
            }

            if ((nota >= 75) && (nota <= 89))
            {
                Console.WriteLine("C1");
            }

            if ((nota >= 90) && (nota <= 100))
            {
                Console.WriteLine("C2");

            }


        }
        
    }
}
