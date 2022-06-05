using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Producto
    {
        public enum ETipoComic { Oriental, Occidental };
        private ETipoComic tipoComic;
        public Comic(double precio, string autor, ETipoComic tipoComic) : base(precio, autor)
        {
            this.tipoComic = tipoComic;
        }

        public ETipoComic TipoComic { get { return this.tipoComic; } }
        public override double CalcularVenta()
        {
            this.estadoCompra = true;
            double precio=0;
            double descuento;
            switch (TipoComic) 
            {
                case ETipoComic.Occidental:
                    descuento = this.Precio * 15 / 100;
                    precio = this.Precio - descuento;
                    break;
                case ETipoComic.Oriental:
                    descuento = this.Precio * 10 / 100;
                    precio = this.Precio - descuento;
                    break;
            }
            return precio;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Tipo de comic: {this.TipoComic}");
            sb.AppendLine($"Precio:${this.Precio}");

            return sb.ToString();
        }
    }
}
