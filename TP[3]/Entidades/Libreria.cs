using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libreria
    {
        private List<Cliente> listaClientes;
        private string dniCliente;


        public Libreria() 
        {
            listaClientes = new List<Cliente>();
        }
        public Libreria(string dniCliente, Producto producto) 
        {
            this.dniCliente = dniCliente;
            
        }

        public string DniCliente { get { return this.dniCliente; } set { this.dniCliente = value; } }
        public List<Cliente> ListaClientes { get { return this.listaClientes; } set { this.listaClientes = value; }  }

        public static bool operator ==(Libreria clientes, Cliente cliente) 
        {
            if(clientes is not null && cliente is not null) 
            {
                foreach(Cliente c in clientes.listaClientes) 
                {
                    if(cliente.Dni == c.Dni)
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Libreria clientes, Cliente cliente) 
        {
            return !(clientes == cliente);
        }

        public static Libreria operator +(Libreria clientes, Cliente cliente) 
        {
            if(clientes is not null && cliente is not null) 
            {
                if(clientes != cliente) 
                {
                    clientes.listaClientes.Add(cliente);
                    cliente.EsCliente = true;
                    
                }
            }
            return clientes;

        }
        public static string operator -(Libreria clientes, Cliente cliente) 
        {
            if(clientes is not null && cliente is not null) 
            {
                if(clientes == cliente) 
                {
                    clientes.listaClientes.Remove(cliente);
                    cliente.EsCliente = false;
                    return "Cliente removido con exito";
                }
            }
            return "Error al remover cliente";
        }
        public static string AgregarVenta(Libreria clientes, Cliente cliente, Producto producto) 
        {
            if(clientes is not null && cliente is not null && producto is not null) 
            {
                if(clientes == cliente) 
                {
                    int index = clientes.listaClientes.IndexOf(cliente);
                    clientes.listaClientes[index].Productos.Add(producto);
                    return "Venta exitosa";
                }
            }
            return "No se encontro el cliente";

        }
        public Cliente BuscarClienteEnLista(string dniCliente) 
        {
            
                foreach(Cliente item in this.listaClientes) 
                {
                    if(item.Dni == dniCliente) 
                    {
                        int index = this.listaClientes.IndexOf((Cliente)item);
                        return listaClientes[index];
                    }
                }

            return new Cliente();
        }
        public bool VerificarClienteDuplicado(Cliente c) 
        {
            foreach(Cliente item in this.listaClientes) 
            {
                if(c.Dni == item.Dni) 
                {
                    return true;
                }
            }
            return false;
        }

        
        public Cliente Vender(Producto p, Cliente c) 
        {
            
            if (c is not null && p is not null)
            {
                c += p;
                p.EstadoCompra = true;
            }
            return c;
        }

        
        public static string GenerarTicket(Cliente c) 
        {
            double precioFinal=0;
            StringBuilder sb = new StringBuilder();
            if(c is not null) 
            {
                sb.AppendLine($"-----------------------");
                sb.AppendLine($"CLIENTE:");
                sb.AppendLine($"Nombre y Apellido {c.Nombre} {c.Apellido}");
                sb.AppendLine($"Dni:{c.Dni}");
                sb.AppendLine($"-----------------------");
                sb.AppendLine($"PRODUCTOS:");
                foreach (Producto p in c.Productos) 
                {
                    if (p.EstadoCompra) 
                    {
                        sb.AppendLine($"{p.ToString()}");
                        precioFinal += p.Precio;
                    }
                }
                sb.AppendLine($"-----------------------");
                sb.AppendLine($"Precio Final: ${precioFinal}");
            }
            return sb.ToString();
        }

    }
}
