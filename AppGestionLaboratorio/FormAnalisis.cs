using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    public partial class FormAnalisis : Form
    {
        public FormAnalisis()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnAniadirAnalisis.FlatStyle = FlatStyle.Flat;
            btnAniadirAnalisis.BackColor = Color.FromArgb(150, 196, 196);
            btnModificarAnalisis.FlatStyle = FlatStyle.Flat;
            btnModificarAnalisis.BackColor = Color.FromArgb(150, 196, 196);
        }

        private void FormAnalisis_Load(object sender, EventArgs e)
        {
            conectar();

            Estilo estilo = new Estilo(this.dgvAnalisis);

            //Introducimos los diferetentes estilos
            estilo.definirCabecera("#315d5d");
            estilo.definirFilas("#96c4c4", "**********");
            dgvAnalisis.BackgroundColor = Color.FromArgb(228, 251, 251);

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgvAnalisis.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        //conectamos con la base de datos
        private void conectar()
        {
            //lectura de la cadena de conexion en app.config
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();

            string sentencia = "SELECT * FROM Analisis ORDER BY Id";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvAnalisis.DataSource = dt;
                comando.Dispose();
                conexion.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

        //Metodo cuando pulsamos en la imagen de salir de debajo de Analisis
        private void btnCerrarAnalisis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos en el boton añadir
        private void btnAniadirAnalisis_Click(object sender, EventArgs e)
        {
            FormGuardarAnalisis guardarAnalisis = new FormGuardarAnalisis();
            guardarAnalisis.ShowDialog();
            conectar();
        }

        //Metodo cuando pulsamos en el boton modificar
        private void btnModificarAnalisis_Click(object sender, EventArgs e)
        {
            if (dgvAnalisis.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAnalisis.CurrentRow;

                FormGuardarAnalisis analisis = new FormGuardarAnalisis(fila);

                analisis.ShowDialog();

                conectar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }
    }
}
