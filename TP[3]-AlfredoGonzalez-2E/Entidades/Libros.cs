using System;
using System.Text;

namespace Entidades
{
    public abstract class Producto
    {
        private static Guid codigo;
        private double precio;
        protected bool estadoCompra;
        private string autor;

        public Producto(double precio, string autor, bool estadoCompra)
        {
            this.precio = precio;
            this.estadoCompra = estadoCompra;
            this.autor = autor;
        }
        public Producto()
        {

        }

        static Producto()
        {
            codigo = Guid.NewGuid();
        }

        public Guid Codigo { get { return codigo; } }

        public string Autor { get { return autor; } }
        public double Precio { get { return precio; } set { this.precio = value; } }

        public static explicit operator Guid(Producto p)
        {
            return new Guid(p.ToString());
        }

        public abstract double CalcularVenta();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.Codigo}");
            sb.AppendLine($"Autor: {this.Autor}");
            if (this.estadoCompra)
            {
                sb.AppendLine($"Estado de la compra: Confirmada");
            }
            else
            {
                sb.AppendLine($"Estado de la compra: No confirmada");
            }
            return sb.ToString();
        }


    }
}
