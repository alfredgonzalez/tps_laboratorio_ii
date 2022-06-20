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
        public frmLibreria()
        {
            InitializeComponent();
            this.libreria = new Libreria();
            Cliente cliente = new Cliente("40142157", "Alfredo", "Gonzalez", "1165589870");
            Cliente cliente2 = new Cliente("aaaaa", "Natasha", "Rojas", "AAAAAAAAA");
            Producto producto1 = new Comic(5000, "Kimetsu no yaiba #1");
            Producto producto2 = new Novela(Novela.EGenero.Drama, 2500, "Rayuela");
            Producto producto3 = new Manga(1500, "Jujutsu kaizen #1");
            Producto producto4 = new Comic(10000, "Spiderman #1");

            libreria.ListaClientes.Add(cliente);
            libreria.ListaClientes.Add(cliente2);
            producto2.Precio = producto2.CalcularVenta();
            producto3.Precio = producto3.CalcularVenta();
            producto4.Precio = producto4.CalcularVenta();
            cliente += producto2;
            cliente += producto3;
            cliente += producto4;
            cliente2 += producto4;
            cliente2 += producto3;
            cliente2 += producto1;

        }

        public void ActualizarLista()
        {
            this.lstClientes.DataSource = null;
            this.lstClientes.DataSource = libreria.ListaClientes;

        }

        private void frmLibreria_Load(object sender, EventArgs e)
        {

            this.lstClientes.DataSource = null;
            this.lstClientes.DataSource = libreria.ListaClientes;
            ActualizarLista();
        }



        private bool ValidarClienteExiste()
        {
            int index = lstClientes.SelectedIndex;
            if (index == -1 && lstClientes.Items.Count == 0)
            {
                throw new ClienteNoExisteExcepcion("Error, no hay clientes en la lista");
            }
            else if (index == -1)
            {
                throw new ClienteNoExisteExcepcion("Error, selecciona un cliente");
            }
            return true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ValidarClienteExiste())
                {
                    int index = lstClientes.SelectedIndex;
                    Cliente cliente = (Cliente)lstClientes.SelectedItem;
                    frmClientes frmClientes = new frmClientes(this.libreria, cliente);
                    frmClientes.ShowDialog();
                }
            }
            catch (ClienteNoExisteExcepcion ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta frmAlta = new frmAlta(this.libreria);
            frmAlta.ShowDialog();
            ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarClienteExiste())
                {
                    int index = lstClientes.SelectedIndex;
                    Cliente cliente = (Cliente)lstClientes.SelectedItem;
                    string mensaje = this.libreria - cliente;
                    this.ActualizarLista();
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ClienteNoExisteExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la accion");
            }
        }
    }
}
