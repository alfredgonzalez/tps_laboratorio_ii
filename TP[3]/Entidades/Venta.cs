using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Venta
    {
        private DateTime fecha;
        static int costoIva;
        private double precioFinal;
        private Producto producto;



        public DateTime Fecha { get { return this.fecha; } set { this.fecha = value; } }

        public double PrecioFinal { get { return this.precioFinal; }}
        static Venta() 
        {
            costoIva = 21;
        }
        public Venta(Producto producto) 
        {
            this.producto = producto;
        }
        public Venta(Producto producto, int stock) 
        {
            this.producto = producto;
        }
        public void Vender(int cantidad) 
        {
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad) 
        {
            double resultado = 0;
            double iva;
            resultado = precioUnidad * cantidad;
            iva = resultado * Venta.costoIva / 100;

            return resultado + iva;
        }
        /*public void Alquilar(Novela novela) 
        {
            if(novela is not null) 
            {
                novela.Alquiler = true;
                novela.HoraAlquiler = DateTime.Now;
            }
        }*/

        private string GenerarTicket(Cliente cliente, Venta venta) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{cliente.ToString()}");
            sb.AppendLine($"Precio {venta.PrecioFinal}");
            sb.AppendLine($"Fecha {venta.Fecha}");
            return sb.ToString();
        }


    }
}
