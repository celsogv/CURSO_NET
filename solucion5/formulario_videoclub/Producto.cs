using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_videoclub
{
    public class Producto
    {


        private int codigo;
        private string descripcion;
        private Decimal precio;
        public Producto(int codigo, string descripcion, Decimal precio)
        {

            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;




        }

        public int pCodigo
        {
            get
            {
                return codigo;


            }
            set
            {

                codigo = value;

            }

        }

        public string pDescripcion
        {
            get
            {
                return descripcion;


            }
            set
            {

                descripcion = value;

            }

        }

        public Decimal pPrecio
        {
            get
            {
                return precio;


            }
            set
            {

                precio = value;

            }

        }



    }  }


