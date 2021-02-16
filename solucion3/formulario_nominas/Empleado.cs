using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_nominas
{
    class Empleado
    {

        protected string nombre;
        protected string identificacion;
        protected Decimal salario;
        protected int dias;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;




        }


        public void setIdentoficacion(string identificacion)
        {
            this.identificacion = identificacion;



        }


        public void setSalario(Decimal salario)
        {
            this.salario = salario;




        }



        public void setDias(int dias)
        {

            this.dias = dias;


        }



        public string getNombre()
        {


            return nombre;
        }


        public string getIdentificacion()
        {

            return identificacion;

        }



        public Decimal getSalario()
        {

            return salario;


        }



        public int getDias()
        {


            return dias;

        }
    }
}
