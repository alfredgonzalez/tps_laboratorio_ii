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
            this.btnAlta = new System.Windows.Forms.Button();
            this.rchListadoProductos = new System.Windows.Forms.RichTextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(25, 27);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(136, 29);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Nuevo Cliente";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // rchListadoProductos
            // 
            this.rchListadoProductos.Location = new System.Drawing.Point(687, 226);
            this.rchListadoProductos.Name = "rchListadoProductos";
            this.rchListadoProductos.Size = new System.Drawing.Size(213, 418);
            this.rchListadoProductos.TabIndex = 6;
            this.rchListadoProductos.Text = "";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(181, 27);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(136, 29);
            this.btnClientes.TabIndex = 11;
            this.btnClientes.Text = "Ingresar";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(25, 106);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(829, 444);
            this.lstClientes.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(323, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 29);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 566);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.rchListadoProductos);
            this.Controls.Add(this.btnAlta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loggin";
            this.Load += new System.EventHandler(this.frmLibreria_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.RichTextBox rchListadoProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnEliminar;
    }
}
