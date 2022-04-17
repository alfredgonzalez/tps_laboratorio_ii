﻿using System;
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
        /// <summary>
        /// Carga el comboBox con los operadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperadores.Items.Add(" ");
            cmbOperadores.Items.Add("+");
            cmbOperadores.Items.Add("-");
            cmbOperadores.Items.Add("*");
            cmbOperadores.Items.Add("/");
        }

        /// <summary>
        /// Al presionar el click Pregunta al usuario si esta seguro que quiere cerrar el programa, en caso de responder si, lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quiere salir?", " " ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }

            
        }
        /// <summary>
        /// Al presionar el boton, convierte a binario el resultado y alista los botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// Al presionar el boton, convierte a decimal el resultado y alista los botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Limpia todos los campos, seteandolos en vacio y 0
        /// </summary>
        private void Limpiar() 
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperadores.SelectedIndex = -1;
            lblResultado.Text = "0";

        }
        /// <summary>
        /// al presionar el boton limpiar llama a la funcion limpiar y setea los botones para operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Recibe los operandos y el operador como parametro y llama al metodo operar
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion</returns>
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
        /// <summary>
        /// Al presionar el boton operar valida que los campos a operar esten llenos y el comboBox no sea null
        /// llama al metodo operar y muestra el lblResultado en pantalla, por ultimo carga el historial de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
