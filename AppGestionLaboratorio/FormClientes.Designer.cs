namespace AppGestionLaboratorio
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbBusquedaSelectiva = new System.Windows.Forms.TextBox();
            this.btnAniadirClientes = new System.Windows.Forms.Button();
            this.btnModificarClientes = new System.Windows.Forms.Button();
            this.btnCerrarClientes = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.Label();
            this.lbClientesBusqueda = new System.Windows.Forms.Label();
            this.btIzqClientes = new System.Windows.Forms.Button();
            this.btDerClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(13, 107);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.Size = new System.Drawing.Size(760, 307);
            this.dgvClientes.TabIndex = 0;
            // 
            // tbBusquedaSelectiva
            // 
            this.tbBusquedaSelectiva.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusquedaSelectiva.Location = new System.Drawing.Point(203, 45);
            this.tbBusquedaSelectiva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusquedaSelectiva.Name = "tbBusquedaSelectiva";
            this.tbBusquedaSelectiva.Size = new System.Drawing.Size(220, 41);
            this.tbBusquedaSelectiva.TabIndex = 1;
            this.tbBusquedaSelectiva.TextChanged += new System.EventHandler(this.tbBusquedaSelectiva_TextChanged);
            // 
            // btnAniadirClientes
            // 
            this.btnAniadirClientes.Location = new System.Drawing.Point(526, 42);
            this.btnAniadirClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAniadirClientes.Name = "btnAniadirClientes";
            this.btnAniadirClientes.Size = new System.Drawing.Size(112, 35);
            this.btnAniadirClientes.TabIndex = 2;
            this.btnAniadirClientes.Text = "Añadir";
            this.btnAniadirClientes.UseVisualStyleBackColor = true;
            this.btnAniadirClientes.Click += new System.EventHandler(this.btnAniadirClientes_Click);
            // 
            // btnModificarClientes
            // 
            this.btnModificarClientes.Location = new System.Drawing.Point(661, 42);
            this.btnModificarClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarClientes.Name = "btnModificarClientes";
            this.btnModificarClientes.Size = new System.Drawing.Size(112, 35);
            this.btnModificarClientes.TabIndex = 3;
            this.btnModificarClientes.Text = "Modificar";
            this.btnModificarClientes.UseVisualStyleBackColor = true;
            this.btnModificarClientes.Click += new System.EventHandler(this.btnModificarClientes_Click);
            // 
            // btnCerrarClientes
            // 
            this.btnCerrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarClientes.FlatAppearance.BorderSize = 0;
            this.btnCerrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarClientes.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.btnCerrarClientes.Location = new System.Drawing.Point(13, 32);
            this.btnCerrarClientes.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCerrarClientes.Name = "btnCerrarClientes";
            this.btnCerrarClientes.Size = new System.Drawing.Size(70, 62);
            this.btnCerrarClientes.TabIndex = 5;
            this.btnCerrarClientes.UseVisualStyleBackColor = true;
            this.btnCerrarClientes.Click += new System.EventHandler(this.btnCerrarClientes_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Location = new System.Drawing.Point(19, 9);
            this.lbClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(66, 20);
            this.lbClientes.TabIndex = 6;
            this.lbClientes.Text = "Clientes";
            // 
            // lbClientesBusqueda
            // 
            this.lbClientesBusqueda.AutoSize = true;
            this.lbClientesBusqueda.Location = new System.Drawing.Point(208, 14);
            this.lbClientesBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientesBusqueda.Name = "lbClientesBusqueda";
            this.lbClientesBusqueda.Size = new System.Drawing.Size(204, 20);
            this.lbClientesBusqueda.TabIndex = 7;
            this.lbClientesBusqueda.Text = "Busqueda por parte de Dni:";
            // 
            // btIzqClientes
            // 
            this.btIzqClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btIzqClientes.Location = new System.Drawing.Point(141, 45);
            this.btIzqClientes.Name = "btIzqClientes";
            this.btIzqClientes.Size = new System.Drawing.Size(45, 28);
            this.btIzqClientes.TabIndex = 8;
            this.btIzqClientes.Text = "<";
            this.btIzqClientes.UseVisualStyleBackColor = false;
            this.btIzqClientes.Click += new System.EventHandler(this.btIzqClientes_Click);
            // 
            // btDerClientes
            // 
            this.btDerClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btDerClientes.Location = new System.Drawing.Point(442, 45);
            this.btDerClientes.Name = "btDerClientes";
            this.btDerClientes.Size = new System.Drawing.Size(49, 28);
            this.btDerClientes.TabIndex = 9;
            this.btDerClientes.Text = ">";
            this.btDerClientes.UseVisualStyleBackColor = false;
            this.btDerClientes.Click += new System.EventHandler(this.btDerClientes_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 425);
            this.Controls.Add(this.btDerClientes);
            this.Controls.Add(this.btIzqClientes);
            this.Controls.Add(this.lbClientesBusqueda);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.btnCerrarClientes);
            this.Controls.Add(this.btnModificarClientes);
            this.Controls.Add(this.btnAniadirClientes);
            this.Controls.Add(this.tbBusquedaSelectiva);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbBusquedaSelectiva;
        private System.Windows.Forms.Button btnAniadirClientes;
        private System.Windows.Forms.Button btnModificarClientes;
        private System.Windows.Forms.Button btnCerrarClientes;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Label lbClientesBusqueda;
        private System.Windows.Forms.Button btIzqClientes;
        private System.Windows.Forms.Button btDerClientes;
    }
}