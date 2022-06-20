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
    public partial class frmAlta : Form
    {
        private Libreria libreria;
        public frmAlta()
        {
            InitializeComponent();
        }
        public frmAlta(Libreria libreria) : this()
        {
            this.libreria = libreria;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtCelular.Text))
                {

                    if (Validaciones.ValidarNombre(txtNombre.Text) && Validaciones.ValidarApellido(txtApellido.Text) && Validaciones.ValidarDni(txtDni.Text) && Validaciones.ValidarNumeroCelular(txtCelular.Text))
                    {
                        Cliente cliente = new Cliente(txtDni.Text, txtNombre.Text, txtApellido.Text, txtCelular.Text);
                        if (libreria.VerificarClienteDuplicado(cliente)) 
                        {
                            MessageBox.Show("Error, el cliente ya esta en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.OK;
                        }
                        else 
                        {
                            this.libreria += cliente;
                            cliente.EsCliente = true;
                            MessageBox.Show("Usted se registro correctamente", "Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            catch (CamposVaciosExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NombreInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DniInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ApellidoInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CelularInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer los datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
