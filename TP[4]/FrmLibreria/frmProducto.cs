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
    public partial class frmProducto : Form
    {
        private Libreria libreria;
        private Cliente cliente;
        int indiceCliente;
        public frmProducto(Libreria libreria, Cliente cliente)
        {
            InitializeComponent();
            this.libreria = libreria;
            this.indiceCliente = libreria.ListaClientes.IndexOf(cliente);
            this.cliente = cliente;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try 
            {
                Cliente cliente = this.cliente;
                double precioAux = 0;
                if(Validaciones.ValidarSoloNumeros(this.txtPrecio.Text) 
                    && Validaciones.ValidarCamposVacios(this.txtPrecio.Text) 
                    && Validaciones.ValidarCamposVacios(this.txtDescripcion.Text)
                    && Validaciones.ValidarSoloLetras(this.txtDescripcion.Text)) 
                {
                    if(cmbTipo.SelectedItem.ToString() == "Manga") 
                    {
                        precioAux = double.Parse(txtPrecio.Text);
                        Producto producto = new Manga(precioAux, txtDescripcion.Text);
                        producto.Precio = producto.CalcularVenta();
                        cliente += producto;
                    }
                    else if(cmbTipo.SelectedItem.ToString() == "Novela") 
                    {
                        precioAux = double.Parse(txtPrecio.Text);
                        Producto producto = new Novela(precioAux, txtDescripcion.Text);
                        producto.Precio = producto.CalcularVenta();
                        cliente += producto;

                    }
                    else if (cmbTipo.SelectedItem.ToString() == "Comic")
                    {
                        precioAux = double.Parse(txtPrecio.Text);
                        Producto producto = new Comic(precioAux, txtDescripcion.Text);
                        producto.Precio = producto.CalcularVenta();
                        cliente += producto;
                    }
                    MessageBox.Show("Producto agregado correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SoloLetrasExcepcion ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposVaciosExcepcion ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(PrecioNoValidoExcepcion ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception) 
            {
                MessageBox.Show("Error!");
            }
        }


        private void frmProducto_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Manga");
            cmbTipo.Items.Add("Comic");
            cmbTipo.Items.Add("Novela");

        }
    }
}
