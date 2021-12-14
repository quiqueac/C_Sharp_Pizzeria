using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPizzeria.Clases
{
    public abstract class Producto
    {
        private string nombre;
        private decimal precio;

        public Producto(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public abstract string Nombre();

        public decimal Precio
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
    }
}
