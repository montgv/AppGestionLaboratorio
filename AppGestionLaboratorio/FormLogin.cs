using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace AppGestionLaboratorio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btInicioSesion.FlatStyle = FlatStyle.Flat;
            btInicioSesion.BackColor = Color.FromArgb(150, 196, 196);
            btSalir.FlatStyle = FlatStyle.Flat;
            btSalir.BackColor = Color.FromArgb(150, 196, 196);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInicioSesion_Click(object sender, EventArgs e)
        {

            //lectura de la cadena de conexion en app.config
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();

            string sentencia = "SELECT * FROM Login WHERE usuario='" + hintTextBoxUsuario.Text + "' AND contrasenia='" + hintTextBoxContrasenia.Text + "'";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
    
                if (dataReader.HasRows == true)
                {
                    MessageBox.Show("Acceso correcto.");
                    Close();
                } else
                {
                    MessageBox.Show("Acceso no válido.");
                }
                comando.Dispose();
                conexion.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

    }
}
