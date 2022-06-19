using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manga : Producto
    {
        public enum EColor { Color, BYN };
        private EColor color;
        private bool esPrimeraEdicion;

        public Manga(double precio, string descripcion, bool estadoCompra) : this(precio, descripcion, false,false, EColor.BYN)
        {

        }
        public Manga(double precio, string descripcion, bool estadoCompra, bool esPrimeraEdicion, EColor color) : base(precio, descripcion, estadoCompra)
        {
            this.esPrimeraEdicion = esPrimeraEdicion;
            this.color = color;
        }
        public Manga()
        {

        }
        public bool EsPrimeraEdicion { get { return esPrimeraEdicion; } set { esPrimeraEdicion = value; } }

        public EColor Color { get { return color; } set { color = value; } }

        public override double CalcularVenta()
        {
            this.estadoCompra = true;
            double precio = 0;
            double aumento;
            if (this.EsPrimeraEdicion) 
            {
                aumento = this.precio * 30 / 100;
                precio = aumento + this.precio;
            }
            else 
            {
                precio = this.precio;
            }
            return precio;
        }
    }
}

