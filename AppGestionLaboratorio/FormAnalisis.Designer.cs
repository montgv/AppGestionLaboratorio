namespace AppGestionLaboratorio
{
    partial class FormAnalisis
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
            this.btnCerrarAnalisis = new System.Windows.Forms.Button();
            this.lbAnalisis = new System.Windows.Forms.Label();
            this.btnAniadirAnalisis = new System.Windows.Forms.Button();
            this.btnModificarAnalisis = new System.Windows.Forms.Button();
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarAnalisis
            // 
            this.btnCerrarAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAnalisis.FlatAppearance.BorderSize = 0;
            this.btnCerrarAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAnalisis.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.btnCerrarAnalisis.Location = new System.Drawing.Point(15, 30);
            this.btnCerrarAnalisis.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCerrarAnalisis.Name = "btnCerrarAnalisis";
            this.btnCerrarAnalisis.Size = new System.Drawing.Size(69, 63);
            this.btnCerrarAnalisis.TabIndex = 7;
            this.btnCerrarAnalisis.UseVisualStyleBackColor = true;
            this.btnCerrarAnalisis.Click += new System.EventHandler(this.btnCerrarAnalisis_Click);
            // 
            // lbAnalisis
            // 
            this.lbAnalisis.AutoSize = true;
            this.lbAnalisis.Location = new System.Drawing.Point(21, 9);
            this.lbAnalisis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnalisis.Name = "lbAnalisis";
            this.lbAnalisis.Size = new System.Drawing.Size(63, 20);
            this.lbAnalisis.TabIndex = 8;
            this.lbAnalisis.Text = "Análisis";
            // 
            // btnAniadirAnalisis
            // 
            this.btnAniadirAnalisis.Location = new System.Drawing.Point(533, 43);
            this.btnAniadirAnalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAniadirAnalisis.Name = "btnAniadirAnalisis";
            this.btnAniadirAnalisis.Size = new System.Drawing.Size(112, 35);
            this.btnAniadirAnalisis.TabIndex = 10;
            this.btnAniadirAnalisis.Text = "Añadir";
            this.btnAniadirAnalisis.UseVisualStyleBackColor = true;
            this.btnAniadirAnalisis.Click += new System.EventHandler(this.btnAniadirAnalisis_Click);
            // 
            // btnModificarAnalisis
            // 
            this.btnModificarAnalisis.Location = new System.Drawing.Point(661, 43);
            this.btnModificarAnalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAnalisis.Name = "btnModificarAnalisis";
            this.btnModificarAnalisis.Size = new System.Drawing.Size(112, 35);
            this.btnModificarAnalisis.TabIndex = 11;
            this.btnModificarAnalisis.Text = "Modificar";
            this.btnModificarAnalisis.UseVisualStyleBackColor = true;
            this.btnModificarAnalisis.Click += new System.EventHandler(this.btnModificarAnalisis_Click);
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.Location = new System.Drawing.Point(13, 108);
            this.dgvAnalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.RowHeadersWidth = 62;
            this.dgvAnalisis.Size = new System.Drawing.Size(760, 303);
            this.dgvAnalisis.TabIndex = 13;
            // 
            // FormAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 425);
            this.Controls.Add(this.dgvAnalisis);
            this.Controls.Add(this.btnModificarAnalisis);
            this.Controls.Add(this.btnAniadirAnalisis);
            this.Controls.Add(this.lbAnalisis);
            this.Controls.Add(this.btnCerrarAnalisis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAnalisis";
            this.Text = "FormAnalisis";
            this.Load += new System.EventHandler(this.FormAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarAnalisis;
        private System.Windows.Forms.Label lbAnalisis;
        private System.Windows.Forms.Button btnAniadirAnalisis;
        private System.Windows.Forms.Button btnModificarAnalisis;
        private System.Windows.Forms.DataGridView dgvAnalisis;
    }
}