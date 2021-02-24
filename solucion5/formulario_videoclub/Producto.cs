using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_videoclub
{
    public class Producto
    {


        private int Codigo;
        private double Precio;
        private string Descripcion;

        public Producto(int codigo, double precio, string descripcion)
        {
            Codigo = codigo;
            Precio = precio;
            Descripcion = descripcion;
        }
        public int MCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public double MPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public string MDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

    }

       


    }  


