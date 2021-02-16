using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {


            Estudiante estudiante1 = new Estudiante();
            Profesor profesor1 = new Profesor();
            estudiante1.SetNombre("nombre estudiante");
            estudiante1.SetApellidos("apellidos estudiante");
            estudiante1.SetEdad(19);
            profesor1.SetNombre("nombre profesor");
            profesor1.SetApellidos("apellidos profesor");
            profesor1.SetEdad(29);
            estudiante1.Estudiar();
            profesor1.Explicar();
            estudiante1.VerEdad();
            Console.ReadLine();






        }
    }
}
