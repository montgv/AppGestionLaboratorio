namespace AppGestionLaboratorio
{
    partial class FormMuestras
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
            this.btnCerrarMuestras = new System.Windows.Forms.Button();
            this.lbMuestras = new System.Windows.Forms.Label();
            this.tbBusquedaMuestras = new System.Windows.Forms.TextBox();
            this.btnAniadirMuestras = new System.Windows.Forms.Button();
            this.btnModificarMuestras = new System.Windows.Forms.Button();
            this.dgvMuestras = new System.Windows.Forms.DataGridView();
            this.lbMuestrasBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarMuestras
            // 
            this.btnCerrarMuestras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMuestras.FlatAppearance.BorderSize = 0;
            this.btnCerrarMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarMuestras.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.btnCerrarMuestras.Location = new System.Drawing.Point(15, 33);
            this.btnCerrarMuestras.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCerrarMuestras.Name = "btnCerrarMuestras";
            this.btnCerrarMuestras.Size = new System.Drawing.Size(71, 66);
            this.btnCerrarMuestras.TabIndex = 6;
            this.btnCerrarMuestras.UseVisualStyleBackColor = true;
            this.btnCerrarMuestras.Click += new System.EventHandler(this.btnCerrarMuestras_Click);
            // 
            // lbMuestras
            // 
            this.lbMuestras.AutoSize = true;
            this.lbMuestras.Location = new System.Drawing.Point(13, 9);
            this.lbMuestras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMuestras.Name = "lbMuestras";
            this.lbMuestras.Size = new System.Drawing.Size(75, 20);
            this.lbMuestras.TabIndex = 7;
            this.lbMuestras.Text = "Muestras";
            // 
            // tbBusquedaMuestras
            // 
            this.tbBusquedaMuestras.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusquedaMuestras.Location = new System.Drawing.Point(153, 49);
            this.tbBusquedaMuestras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusquedaMuestras.Name = "tbBusquedaMuestras";
            this.tbBusquedaMuestras.Size = new System.Drawing.Size(299, 41);
            this.tbBusquedaMuestras.TabIndex = 8;
            this.tbBusquedaMuestras.TextChanged += new System.EventHandler(this.tbBusquedaMuestras_TextChanged);
            // 
            // btnAniadirMuestras
            // 
            this.btnAniadirMuestras.Location = new System.Drawing.Point(523, 42);
            this.btnAniadirMuestras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAniadirMuestras.Name = "btnAniadirMuestras";
            this.btnAniadirMuestras.Size = new System.Drawing.Size(112, 35);
            this.btnAniadirMuestras.TabIndex = 9;
            this.btnAniadirMuestras.Text = "Añadir";
            this.btnAniadirMuestras.UseVisualStyleBackColor = true;
            this.btnAniadirMuestras.Click += new System.EventHandler(this.btnAniadirMuestras_Click);
            // 
            // btnModificarMuestras
            // 
            this.btnModificarMuestras.Location = new System.Drawing.Point(661, 42);
            this.btnModificarMuestras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarMuestras.Name = "btnModificarMuestras";
            this.btnModificarMuestras.Size = new System.Drawing.Size(112, 35);
            this.btnModificarMuestras.TabIndex = 10;
            this.btnModificarMuestras.Text = "Modificar";
            this.btnModificarMuestras.UseVisualStyleBackColor = true;
            this.btnModificarMuestras.Click += new System.EventHandler(this.btnModificarMuestras_Click);
            // 
            // dgvMuestras
            // 
            this.dgvMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestras.Location = new System.Drawing.Point(13, 100);
            this.dgvMuestras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMuestras.Name = "dgvMuestras";
            this.dgvMuestras.RowHeadersWidth = 62;
            this.dgvMuestras.Size = new System.Drawing.Size(760, 303);
            this.dgvMuestras.TabIndex = 12;
            // 
            // lbMuestrasBusqueda
            // 
            this.lbMuestrasBusqueda.AutoSize = true;
            this.lbMuestrasBusqueda.Location = new System.Drawing.Point(228, 17);
            this.lbMuestrasBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMuestrasBusqueda.Name = "lbMuestrasBusqueda";
            this.lbMuestrasBusqueda.Size = new System.Drawing.Size(171, 20);
            this.lbMuestrasBusqueda.TabIndex = 15;
            this.lbMuestrasBusqueda.Text = "Busqueda por nombre:";
            // 
            // FormMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 425);
            this.Controls.Add(this.lbMuestrasBusqueda);
            this.Controls.Add(this.dgvMuestras);
            this.Controls.Add(this.btnModificarMuestras);
            this.Controls.Add(this.btnAniadirMuestras);
            this.Controls.Add(this.tbBusquedaMuestras);
            this.Controls.Add(this.lbMuestras);
            this.Controls.Add(this.btnCerrarMuestras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMuestras";
            this.Text = "FormMuestras";
            this.Load += new System.EventHandler(this.FormMuestras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarMuestras;
        private System.Windows.Forms.Label lbMuestras;
        private System.Windows.Forms.TextBox tbBusquedaMuestras;
        private System.Windows.Forms.Button btnAniadirMuestras;
        private System.Windows.Forms.Button btnModificarMuestras;
        private System.Windows.Forms.DataGridView dgvMuestras;
        private System.Windows.Forms.Label lbMuestrasBusqueda;
    }
}