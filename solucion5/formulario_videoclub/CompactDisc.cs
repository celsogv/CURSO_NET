using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_videoclub
{
    class CompactDisc : Producto
    {



        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private string Artista;
        private string Discografica;

        /// <summary>
        /// Contrudctor con parámetros
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        /// <param name="artista"></param>
        /// <param name="discografica"></param>
        public CompactDisc(int codigo, double precio, string descripcion, string artista, string discografica) : base(codigo, precio, descripcion)
        {
            Artista = artista;
            Discografica = discografica;
        }
        public string PArtista
        {
            get { return Artista; }
            set { Artista = value; }
        }
        public string PDiscografica
        {
            get { return Discografica; }
            set { Discografica = value; }
        }
    }
}
