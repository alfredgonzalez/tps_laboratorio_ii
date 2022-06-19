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
        public Comic(double precio, string descripcion, bool estadoCompra, ETipoComic tipoComic) : base(precio, descripcion, estadoCompra)
        {
            this.tipoComic = tipoComic;
        }
        public Comic(double precio, string descripcion, bool estadoCompra) :this(precio, descripcion, false, ETipoComic.Oriental) 
        {

        }

        public ETipoComic TipoComic { get { return this.tipoComic; } }
        public override double CalcularVenta()
        {
            this.estadoCompra = true;
            double precio = 0;
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

    }
}