using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private List<Producto> productos;
        private string dni;
        private string nombre;
        private string apellido;
        private string celular;
        private bool esCliente;

        public Cliente() 
        {
            this.productos = new List<Producto>();
        }
        public Cliente(string dni, string nombre, string apellido, string celular) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.esCliente = true;
        }

        public string Dni { get { return this.dni; } set { this.dni = value; } }

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido {get { return this.apellido; } set { this.apellido = value;} }
        public string Celular { get { return this.celular; } set { this.celular = value; } }
        public bool EsCliente { get { return this.esCliente; } set { this.esCliente = value;} }
        public List<Producto> Productos { get { return this.productos; } set { this.productos = value; } }

        public static Cliente operator +(Cliente c1, Producto p1) 
        {
            if(c1 is not null && p1 is not null) 
            {
                if(c1 != p1) 
                {
                    c1.Productos.Add(p1);
                    
                }
            }
            return c1;
        }
        public static bool operator == (Cliente c1, Cliente c2) 
        {
            if(c1 is not null && c2 is not null) 
            {
                return c1.Dni == c2.Dni;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2) 
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Cliente cliente, Producto producto) 
        {
            if(cliente is not null && producto is not null) 
            {
                foreach(Producto p in cliente.Productos) 
                {
                    if(p == producto)
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Cliente cliente, Producto producto) 
        {
            return !(cliente == producto);
        }
        public string ListarProductos(Cliente cliente) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in cliente.Productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public void ConfirmarCompra() 
        {
            foreach(Producto item in this.Productos) 
            {
                item.EstadoCompra = true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Celular: {this.Celular}");

            return sb.ToString();
        }

    }
}
