namespace Terminal
{
    partial class frmLibreria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVender = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rchListadoProductos = new System.Windows.Forms.RichTextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(220, 129);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(94, 29);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(362, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(73, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(505, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(106, 27);
            this.txtApellido.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 386);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // rchListadoProductos
            // 
            this.rchListadoProductos.Location = new System.Drawing.Point(362, 106);
            this.rchListadoProductos.Name = "rchListadoProductos";
            this.rchListadoProductos.Size = new System.Drawing.Size(485, 418);
            this.rchListadoProductos.TabIndex = 6;
            this.rchListadoProductos.Text = "";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(25, 62);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(125, 27);
            this.txtDni.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(687, 60);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(125, 27);
            this.txtCelular.TabIndex = 9;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(12, 234);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(185, 124);
            this.lstClientes.TabIndex = 10;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(220, 60);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(94, 29);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Text = "Ingresar";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(25, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 20);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "Dni";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(362, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(505, 19);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(687, 19);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 20);
            this.lblCelular.TabIndex = 15;
            this.lblCelular.Text = "Celular";
            // 
            // frmLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 566);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.rchListadoProductos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnVender);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loggin";
            this.Load += new System.EventHandler(this.frmLibreria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox rchListadoProductos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCelular;
    }
}
