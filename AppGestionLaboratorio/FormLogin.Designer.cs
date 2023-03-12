namespace AppGestionLaboratorio
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalir = new System.Windows.Forms.Button();
            this.btInicioSesion = new System.Windows.Forms.Button();
            this.hintTextBoxUsuario = new PersonalizarHint.HintTextBox();
            this.hintTextBoxContrasenia = new PersonalizarHint.HintTextBox();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.White;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSalir.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSalir.Location = new System.Drawing.Point(454, 273);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(240, 55);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btInicioSesion
            // 
            this.btInicioSesion.BackColor = System.Drawing.Color.White;
            this.btInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btInicioSesion.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicioSesion.Location = new System.Drawing.Point(147, 273);
            this.btInicioSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInicioSesion.Name = "btInicioSesion";
            this.btInicioSesion.Size = new System.Drawing.Size(240, 55);
            this.btInicioSesion.TabIndex = 2;
            this.btInicioSesion.Text = "Iniciar Sesión";
            this.btInicioSesion.UseVisualStyleBackColor = false;
            this.btInicioSesion.Click += new System.EventHandler(this.btInicioSesion_Click);
            // 
            // hintTextBoxUsuario
            // 
            this.hintTextBoxUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBoxUsuario.Location = new System.Drawing.Point(249, 67);
            this.hintTextBoxUsuario.Name = "hintTextBoxUsuario";
            this.hintTextBoxUsuario.Size = new System.Drawing.Size(311, 41);
            this.hintTextBoxUsuario.TabIndex = 4;
            this.hintTextBoxUsuario.Text = "Usuario";
            // 
            // hintTextBoxContrasenia
            // 
            this.hintTextBoxContrasenia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBoxContrasenia.Location = new System.Drawing.Point(249, 161);
            this.hintTextBoxContrasenia.Name = "hintTextBoxContrasenia";
            this.hintTextBoxContrasenia.Size = new System.Drawing.Size(311, 41);
            this.hintTextBoxContrasenia.TabIndex = 5;
            this.hintTextBoxContrasenia.Text = "Contraseña";
            this.hintTextBoxContrasenia.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.hintTextBoxContrasenia);
            this.Controls.Add(this.hintTextBoxUsuario);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btInicioSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btInicioSesion;
        private PersonalizarHint.HintTextBox hintTextBoxUsuario;
        private PersonalizarHint.HintTextBox hintTextBoxContrasenia;
    }
}

