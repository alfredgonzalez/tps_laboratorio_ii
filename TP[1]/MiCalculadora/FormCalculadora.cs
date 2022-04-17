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


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperadores.Items.Add(" ");
            cmbOperadores.Items.Add("+");
            cmbOperadores.Items.Add("-");
            cmbOperadores.Items.Add("*");
            cmbOperadores.Items.Add("/");
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quiere salir?", " " ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }

            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void Limpiar() 
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperadores.SelectedIndex = -1;
            lblResultado.Text = "0";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private double Operar(string numero1, string numero2, string operador) 
        {
            double resultado;
            char operadorChar;
            if(!char.TryParse(operador, out operadorChar) || string.IsNullOrEmpty(operador)) 
            {
                operadorChar = 'x';
            }

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            resultado = Calculadora.Operar(operando1 , operando2 , operadorChar);
            return resultado;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador;

            if (string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Debe ingresar dos operandos validos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!double.TryParse(txtNumero1.Text, out double numeros) || !double.TryParse(txtNumero2.Text, out numeros) || Double.IsNaN(numeros))
                {
                    MessageBox.Show("Numeros invados, por favor ingresalos nuevamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (cmbOperadores.SelectedItem == null)
                    {
                        cmbOperadores.Text = "+";
                        operador = "+";
                    }
                    else 
                    {
                        operador = cmbOperadores.SelectedItem.ToString();
                    }

                }
                    lblResultado.Text = Operar(txtNumero1.Text.Replace(".", ","), txtNumero2.Text.Replace(".", ","), cmbOperadores.Text).ToString();
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = false;
            }
            if(!string.IsNullOrEmpty(txtNumero1.Text) && !string.IsNullOrEmpty(txtNumero2.Text) && cmbOperadores.TabIndex != -1)  
            {
                listOperaciones.Items.Add($"{txtNumero1.Text.Replace(".", ",")}  {cmbOperadores.Text}  {txtNumero2.Text.Replace(".", ",")} = {lblResultado.Text.Replace(".", ",")}");
            }
        }
    }
}
