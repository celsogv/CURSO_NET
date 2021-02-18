using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_clientes
{
    class Persona
    {
        private DateTime _dtmFechaNacimiento;
        public string _strNombre

        {

            get
            {
                return _strNombre;


            }

            set
            {

                _strNombre = value;


            }

        }
       


        public DateTime FechaNacimiento
        {

            get
            {
                return _dtmFechaNacimiento;


            }

            set
            {

                _dtmFechaNacimiento = value;




            }

        }



        public int CalcularEdad()
        {
            int intEdad;
            TimeSpan intervalo;
            intervalo = DateTime.Now - this.FechaNacimiento;
            intEdad = (int)(intervalo.Days / 365.25);
            return (intEdad);




        }

    }
}
