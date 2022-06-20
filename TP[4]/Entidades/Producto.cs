using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Manga)), XmlInclude(typeof(Novela)), XmlInclude(typeof(Comic)), XmlInclude(typeof(Producto))]
    public abstract class Producto
    {
        protected string codigoProducto;
        protected double precio;
        protected bool estadoCompra;
        protected string descripcion;

        public Producto(double precio, string descripcion, bool estadoCompra)
        {
            this.precio = precio;
            this.estadoCompra = estadoCompra;
            this.descripcion = descripcion;
           
        }
        public Producto(double precio, string descripcion) : this(precio, descripcion, false)
        {
            
        }

        public Producto()
        {
            
        }

        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value;} }
        public double Precio { get { return this.precio; } set { this.precio = value; } }
        
        public string CodigoProducto { get { return codigoProducto; } set { this.codigoProducto = value;} }

        public bool EstadoCompra { get { return this.estadoCompra; } set { this.estadoCompra = value; } }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public abstract double CalcularVenta();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.GetHashCode()}");
            sb.AppendLine($"descripcion: {this.Descripcion}");
            if (this.EstadoCompra)
            {
                sb.AppendLine($"Estado de la compra: Confirmada");
            }
            else
            {
                sb.AppendLine($"Estado de la compra: No confirmada");
            }
            sb.AppendLine($"Precio: ${this.Precio}");
            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2) 
        {
            bool todoOk = false;
            if(p1 is not null && p2 is not null && p1.GetHashCode() == p2.GetHashCode()) 
            {
                todoOk = true;
            }
            return todoOk;
        }
        public static bool operator !=(Producto p1, Producto p2) 
        {
            return !(p1 == p2);
        }

    }
}
