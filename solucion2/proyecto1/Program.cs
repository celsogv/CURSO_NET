using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();

        }
    }
}
