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

namespace Terminal
{
    public partial class frmLibreria : Form
    {
        private Libreria libreria;
        private Cliente cliente2;
        public frmLibreria()
        {
            InitializeComponent();
            this.libreria = new Libreria();
            Cliente cliente = new Cliente("11111", "Alfredo", "Gonzalez", "111111");
            Cliente cliente2 = new Cliente("aaaaa", "Natasha", "Rojas", "AAAAAAAAA");
            Producto producto1 = new Comic(5000, "Kimetsu no yaiba #1", false);
            Producto producto2 = new Novela(Novela.EGenero.Drama, 2500, "Rayuela", false);
            Producto producto3 = new Manga(1500, "Jujutsu kaizen #1", false, true, Manga.EColor.BYN);
            Producto producto4 = new Comic(10000, "Spiderman #1", false, Comic.ETipoComic.Oriental);

            libreria.ListaClientes.Add(cliente);
            libreria.ListaClientes.Add(cliente2);
            cliente += producto2;
            cliente += producto3;
            cliente += producto4;
            cliente2 += producto4;
            cliente2 += producto3;
            cliente2 += producto1;

        }
        private bool ValidarCliente()
        {
            /*Cliente cliente = new Cliente("xxxxxx", txtNombre.Text, txtApellido.Text, "xxxxxx");
            if(libreria.BuscarClienteEnLista(cliente)) 
            {
                return true;
            }*/
            return false;

        }
        public void ActualizarLista()
        {

            this.lstClientes.Text = this.libreria.ToString();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVentas  frmVentas = new frmVentas();
            frmVentas.Show();
        }

        private void frmLibreria_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente = libreria.BuscarClienteEnLista(txtDni.Text);
            if (this.libreria != cliente)
            {
                throw new ClienteNoExisteExcepcion("No existe ese cliente en la base de datos");
            }
            else
            {
                this.rchListadoProductos.Text = cliente.ListarProductos(cliente);
                this.txtNombre.Text = cliente.Nombre;
                this.txtApellido.Text = cliente.Apellido;
                this.txtCelular.Text = cliente.Celular;

            }


        }
    }
    
}
