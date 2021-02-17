using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_alumnos
{
    class Profesor : Persona
    {



        private double _dlbSueldo;


        public double sueldo
        {

            get
            {

                return _dlbSueldo;
            }


            set
            {

                _dlbSueldo = value;



            }

        }



        public string Ensenar()
        {


            return "Enseñar";
        }
    }
}
