using System;

namespace ejercicio_metodos
{
    class Program
    {

       
        

        static void Main(string[] args)
        {
            string valornombre;
            string valoredad;
            string valornota;
            persona alumno = new persona();


            
            Console.WriteLine("Introduce el nombre: ");
            valornombre = Console.ReadLine();

            Console.WriteLine("Introduce la edad: ");
            valoredad = Console.ReadLine();

            Console.WriteLine("Introduce la nota: ");
            valornota = Console.ReadLine();

            alumno.setNombre(valornombre);
            alumno.setEdad(int.Parse(valoredad));
            alumno.setNota(Decimal.Parse(valornota));
            alumno.mostrarDator();
            alumno.mostrarCurso();



        }
    }
}
