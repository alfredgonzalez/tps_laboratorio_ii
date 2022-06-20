using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Excepciones;

namespace Terminal
{
    public partial class frmClientes : Form
    {
        private Libreria libreria;
        private Cliente cliente;
        int indiceCliente;

        public frmClientes()
        {

        }
        public frmClientes(Libreria libreria, Cliente cliente)
        {
            InitializeComponent();
            this.libreria = libreria;
            this.indiceCliente = libreria.ListaClientes.IndexOf(cliente);
            this.cliente = cliente;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }

        private void ActualizarLista()
        {
            this.lstProductos.DataSource = null;
            this.lstProductos.DataSource = libreria.ListaClientes[indiceCliente].Productos;
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = this.cliente;
                if (ValidarExisteProducto(cliente))
                {
                    ArchivoTxt archivoTexto = new ArchivoTxt();
                    string mensaje = archivoTexto.Escribir($"{cliente.Nombre}{cliente.Apellido} ", Libreria.GenerarTicket(cliente));
                    MessageBox.Show(mensaje, "Ticket generado", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (ProductoNoExisteExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

        }
        public static bool ValidarExisteProducto(Cliente c)
        {
            if(c.Productos.Count <= 0) 
            { 
                throw new ProductoNoExisteExcepcion("El cliente no tiene ningun producto"); 
            }
            return true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.cliente;
            frmProducto frmProductos = new frmProducto(this.libreria, cliente);
            frmProductos.ShowDialog();
            this.ActualizarLista();
        }
    }
}
