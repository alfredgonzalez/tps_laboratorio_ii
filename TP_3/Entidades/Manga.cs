using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Manga : Producto
    {
        public enum EColor { Color, BYN};
        private EColor color;
        private bool esPrimeraEdicion;

        public Manga(double precio, string autor, bool estadoCompra) :this(0000, "XXXX", false, false, EColor.BYN) 
        {
            
        }
        public Manga(double precio, string autor, bool estadoCompra, bool esPrimeraEdicion, EColor color) : base(precio, autor, estadoCompra)
        {
            this.esPrimeraEdicion=esPrimeraEdicion;
            this.color = color;
        }
        public Manga() 
        {

        }
        public bool EsPrimeraEdicion { get { return esPrimeraEdicion; } set { esPrimeraEdicion = value; } }

        public EColor Color { get { return color; } set { color = value; } }

        public override double CalcularVenta()
        {
            throw new NotImplementedException();
        }
    }
}
