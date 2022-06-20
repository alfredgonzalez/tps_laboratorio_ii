using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Producto
    {
        public enum EGenero { Terror, Drama, Comedia, Policial };
        private EGenero genero;
        private static double ValorHoraAlquiler;
        private DateTime horaAlquiler;
        private DateTime horaDevolucion;
        private bool alquiler;
        public Novela(double precio, string descripcion, bool estadoCompra, bool alquiler) : base(precio, descripcion, estadoCompra)
        {
            this.alquiler = alquiler;

        }
        public Novela(double precio, string descripcion) : this(precio, descripcion, false, false)
        {
            
        }


        static Novela()
        {
            Novela.ValorHoraAlquiler = 200.00D;
        }
        public EGenero Genero { get { return genero; } }
        public DateTime HoraAlquiler { get { return horaAlquiler; } set { this.horaAlquiler = value; } }
        public DateTime HoraDevolucion
        {
            get
            {
                return horaDevolucion;
            }
            set
            {
                if (horaDevolucion > horaAlquiler)
                {
                    this.horaDevolucion = value;
                }
            }
        }
        public bool Alquiler { get { return alquiler; } set { alquiler = value; } }
        /*private void RealizarAlquiler()
        {
            this.Alquiler = true;
            this.HoraAlquiler = DateTime.UtcNow;

        }*/
        public double CargoAlquiler()
        {
            DateTime ingreso = HoraAlquiler;
            DateTime devolucion = DateTime.Now;
            TimeSpan resultado = ingreso.Subtract(devolucion);
            double resultadoDouble;
            //RealizarAlquiler();

            resultadoDouble = resultado.TotalHours;
            resultadoDouble *= Novela.ValorHoraAlquiler;
            return resultadoDouble;
        }
        private DateTime ValidarDevolucion(DateTime horaAlquiler)
        {
            if (this.HoraDevolucion > horaAlquiler)
            {
                return HoraDevolucion;
            }
            return DateTime.Now;
        }
        public override double CalcularVenta()
        {

            this.estadoCompra = true;
            double precio = 0;
            double descuento;
            switch (this.Genero)
            {
                case EGenero.Terror:
                    descuento = this.Precio * 20 / 100;
                    precio = this.Precio - descuento;
                    break;
                case EGenero.Drama:
                    descuento = this.Precio * 15 / 100;
                    precio = this.Precio - descuento;
                    break;
                case EGenero.Comedia:
                    descuento = this.Precio * 10 / 100;
                    precio = this.Precio - descuento;
                    break;
                case EGenero.Policial:
                    descuento = this.Precio * 5 / 100;
                    precio = this.Precio - descuento;
                    break;
            }
            return precio;

        }


    }
}