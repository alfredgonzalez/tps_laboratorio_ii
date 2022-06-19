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
        private List<Venta> listaVentas;
        private string dniCliente;

        public Libreria() 
        {
            listaClientes = new List<Cliente>();
            listaVentas = new List<Venta>();
        }
        public Libreria(string dniCliente) 
        {
            this.dniCliente = dniCliente;
        }

        public string DniCliente { get { return this.dniCliente; } set { this.dniCliente = value; } }
        public List<Cliente> ListaClientes { get { return this.listaClientes; } set { this.listaClientes = value; }  }
        public List<Venta> ListaVentas { get { return this.listaVentas; } set { this.listaVentas = value; } }

        public static bool operator ==(Libreria clientes, Cliente cliente) 
        {
            if(clientes is not null && cliente is not null) 
            {
                foreach(Cliente c in clientes.listaClientes) 
                {
                    if(cliente == c)
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

        private string MostrarInfoClientes()
        {
            StringBuilder datos = new StringBuilder();
            foreach (Cliente cliente in listaClientes)
            {
                cliente.ToString();
            }
            return datos.ToString();
        }
        public override string ToString()
        {
            return MostrarInfoClientes();
        }
        public Cliente Vender(Producto p, int cantidad, Cliente c) 
        {
            
            if (c is not null && p is not null)
            {
                c += p;
            }
            return c;
        }
        public Venta Vender(Producto p) 
        {
            Venta venta = new Venta(p);
            if (venta is not null)
            {
                listaVentas.Add(venta);
            }
            return venta;
        }
        public string ListarVentas() 
        {
            StringBuilder sb = new StringBuilder();
            foreach(Venta item in listaVentas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }
        public bool ValidarCliente(string nombre, string apellido, string dni, string celular) 
        {
            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) 
                || string.IsNullOrWhiteSpace(dni)|| string.IsNullOrWhiteSpace(celular))
            {
                throw new CamposVaciosExcepcion("Error! faltan datos de cliente");

            }
            return true;
        }

    }
}
