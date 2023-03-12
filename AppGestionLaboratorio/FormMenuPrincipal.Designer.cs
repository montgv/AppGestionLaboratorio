namespace AppGestionLaboratorio
{
    partial class FormMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuFacturas = new System.Windows.Forms.Button();
            this.btnMenuInformes = new System.Windows.Forms.Button();
            this.btnMenuAnalisis = new System.Windows.Forms.Button();
            this.btnMenuMuestras = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelContenedor);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Controls.Add(this.panelInferior);
            this.panelPrincipal.Controls.Add(this.panelBarraTitulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1000, 550);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(214, 60);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(786, 425);
            this.panelContenedor.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.panelMenu.Controls.Add(this.btnMenuFacturas);
            this.panelMenu.Controls.Add(this.btnMenuInformes);
            this.panelMenu.Controls.Add(this.btnMenuAnalisis);
            this.panelMenu.Controls.Add(this.btnMenuMuestras);
            this.panelMenu.Controls.Add(this.btnMenuClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 425);
            this.panelMenu.TabIndex = 7;
            // 
            // btnMenuFacturas
            // 
            this.btnMenuFacturas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuFacturas.FlatAppearance.BorderSize = 0;
            this.btnMenuFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenuFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMenuFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFacturas.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuFacturas.Image = global::AppGestionLaboratorio.Properties.Resources.ic_factura;
            this.btnMenuFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFacturas.Location = new System.Drawing.Point(0, 305);
            this.btnMenuFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuFacturas.Name = "btnMenuFacturas";
            this.btnMenuFacturas.Size = new System.Drawing.Size(214, 79);
            this.btnMenuFacturas.TabIndex = 18;
            this.btnMenuFacturas.Text = "Facturas";
            this.btnMenuFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuFacturas.UseVisualStyleBackColor = true;
            this.btnMenuFacturas.Click += new System.EventHandler(this.btnMenuFacturas_Click);
            // 
            // btnMenuInformes
            // 
            this.btnMenuInformes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuInformes.FlatAppearance.BorderSize = 0;
            this.btnMenuInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenuInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMenuInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInformes.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuInformes.Image = global::AppGestionLaboratorio.Properties.Resources.ic_informes;
            this.btnMenuInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInformes.Location = new System.Drawing.Point(0, 229);
            this.btnMenuInformes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuInformes.Name = "btnMenuInformes";
            this.btnMenuInformes.Size = new System.Drawing.Size(214, 79);
            this.btnMenuInformes.TabIndex = 17;
            this.btnMenuInformes.Text = "Informes";
            this.btnMenuInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuInformes.UseVisualStyleBackColor = true;
            this.btnMenuInformes.Click += new System.EventHandler(this.btnMenuInformes_Click);
            // 
            // btnMenuAnalisis
            // 
            this.btnMenuAnalisis.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuAnalisis.FlatAppearance.BorderSize = 0;
            this.btnMenuAnalisis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenuAnalisis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMenuAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAnalisis.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuAnalisis.Image = global::AppGestionLaboratorio.Properties.Resources.ic_analisis;
            this.btnMenuAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAnalisis.Location = new System.Drawing.Point(0, 156);
            this.btnMenuAnalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuAnalisis.Name = "btnMenuAnalisis";
            this.btnMenuAnalisis.Size = new System.Drawing.Size(214, 79);
            this.btnMenuAnalisis.TabIndex = 16;
            this.btnMenuAnalisis.Text = "Análisis";
            this.btnMenuAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAnalisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuAnalisis.UseVisualStyleBackColor = true;
            this.btnMenuAnalisis.Click += new System.EventHandler(this.btnMenuAnalisis_Click);
            // 
            // btnMenuMuestras
            // 
            this.btnMenuMuestras.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuMuestras.FlatAppearance.BorderSize = 0;
            this.btnMenuMuestras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenuMuestras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMenuMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMuestras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMuestras.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuMuestras.Image = global::AppGestionLaboratorio.Properties.Resources.ic_muestras;
            this.btnMenuMuestras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMuestras.Location = new System.Drawing.Point(0, 5);
            this.btnMenuMuestras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuMuestras.Name = "btnMenuMuestras";
            this.btnMenuMuestras.Size = new System.Drawing.Size(214, 79);
            this.btnMenuMuestras.TabIndex = 15;
            this.btnMenuMuestras.Text = "Muestras";
            this.btnMenuMuestras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMuestras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuMuestras.UseVisualStyleBackColor = true;
            this.btnMenuMuestras.Click += new System.EventHandler(this.btnMenuMuestras_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnMenuClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnMenuClientes.Image = global::AppGestionLaboratorio.Properties.Resources.ic_clientes;
            this.btnMenuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Location = new System.Drawing.Point(0, 78);
            this.btnMenuClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Size = new System.Drawing.Size(218, 79);
            this.btnMenuClientes.TabIndex = 14;
            this.btnMenuClientes.Text = "Clientes";
            this.btnMenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuClientes.UseVisualStyleBackColor = true;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelInferior.Controls.Add(this.lbHora);
            this.panelInferior.Controls.Add(this.lbFecha);
            this.panelInferior.Controls.Add(this.btnSalir);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 485);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1000, 65);
            this.panelInferior.TabIndex = 6;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(840, 21);
            this.lbHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(71, 35);
            this.lbHora.TabIndex = 18;
            this.lbHora.Text = "Hora";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(300, 21);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(82, 35);
            this.lbFecha.TabIndex = 17;
            this.lbFecha.Text = "Fecha";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ErrorImage = global::AppGestionLaboratorio.Properties.Resources.ic_user_cerrar;
            this.btnSalir.Image = global::AppGestionLaboratorio.Properties.Resources.ic_user_cerrar;
            this.btnSalir.Location = new System.Drawing.Point(6, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(66, 65);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 14;
            this.btnSalir.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panelBarraTitulo.Controls.Add(this.button3);
            this.panelBarraTitulo.Controls.Add(this.button2);
            this.panelBarraTitulo.Controls.Add(this.button1);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnNormal);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.lbTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1000, 60);
            this.panelBarraTitulo.TabIndex = 2;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.button3.Location = new System.Drawing.Point(936, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 58);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AppGestionLaboratorio.Properties.Resources.ic_maximizar;
            this.button2.Location = new System.Drawing.Point(867, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 58);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AppGestionLaboratorio.Properties.Resources.ic_minimizar;
            this.button1.Location = new System.Drawing.Point(798, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 58);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::AppGestionLaboratorio.Properties.Resources.ic_minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1799, 17);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(57, 58);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = global::AppGestionLaboratorio.Properties.Resources.ic_maximizar;
            this.btnNormal.Location = new System.Drawing.Point(1869, 17);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(57, 58);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.btnCerrar.Location = new System.Drawing.Point(1937, 17);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 58);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbTitulo.Location = new System.Drawing.Point(204, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(622, 60);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "App Gestión del Laboratorio";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenuPrincipal";
            this.Text = "APP GESTIÓN DEL LABORATORIO";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuFacturas;
        private System.Windows.Forms.Button btnMenuInformes;
        private System.Windows.Forms.Button btnMenuAnalisis;
        private System.Windows.Forms.Button btnMenuMuestras;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Panel panelContenedor;
    }
}