using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_alumnos
{
    class Persona
    {



        private string _strNombre;
        public string Nombre
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

        public string Asistir()
        {

            return "Asistir a la escuela";

        }



        
    }
}
