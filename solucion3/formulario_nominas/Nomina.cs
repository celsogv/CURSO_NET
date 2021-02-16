using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_nominas
{

    
    class Nomina : Empleado
    {
        protected Decimal sueldo;
        protected int valordias;
        protected Decimal resultado;
        



        public Decimal getValorSalario()
        {
            resultado = salario * dias;
            return resultado;



        }
    }
}
