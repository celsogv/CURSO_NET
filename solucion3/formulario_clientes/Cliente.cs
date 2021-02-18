using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_clientes
{
    class Cliente : Persona
    {



        public bool EsMayorEdad()
        {
            int intEdad;
            intEdad = base.CalcularEdad();
            if (intEdad >= 18) return (true);
            else return (false);



        }
    }
}
