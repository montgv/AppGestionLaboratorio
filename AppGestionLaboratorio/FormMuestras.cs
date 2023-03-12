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
    public partial class FormMuestras : Form
    {
        public FormMuestras()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnAniadirMuestras.FlatStyle = FlatStyle.Flat;
            btnAniadirMuestras.BackColor = Color.FromArgb(150, 196, 196);
            btnModificarMuestras.FlatStyle = FlatStyle.Flat;
            btnModificarMuestras.BackColor = Color.FromArgb(150, 196, 196);
        }

        private void FormMuestras_Load(object sender, EventArgs e)
        {
            conectar();

            Estilo estilo = new Estilo(this.dgvMuestras);
            
            //Introducimos los diferetentes estilos
            estilo.definirCabecera("#315d5d");
            estilo.definirFilas("#96c4c4", "**********");
            dgvMuestras.BackgroundColor = Color.FromArgb(228, 251, 251);

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgvMuestras.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        //Conectamos con la base de datos
        private void conectar()
        {
            //lectura de la cadena de conexion en app.config
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();

            string sentencia = "SELECT * FROM Muestra ORDER BY Id";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvMuestras.DataSource = dt;
                comando.Dispose();
                conexion.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

        //Metodo cuando pulsamos en la imagen de salir de debajo de muestras
        private void btnCerrarMuestras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos en el boton añadir
        private void btnAniadirMuestras_Click(object sender, EventArgs e)
        {
            FormGuardarMuestra guardarMuestra = new FormGuardarMuestra();
            guardarMuestra.ShowDialog();
            conectar();
        }

        //Metodo cuando pulsamos en el boton modificar
        private void btnModificarMuestras_Click(object sender, EventArgs e)
        {
            if (dgvMuestras.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvMuestras.CurrentRow;

                FormGuardarMuestra muestra = new FormGuardarMuestra(fila);

                muestra.ShowDialog();

                conectar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }

        //Evento que al cambiar el texto del textBox filtra por consultarPorNombre
        private void tbBusquedaMuestras_TextChanged(object sender, EventArgs e)
        {
            consultarPorNombre();
        }

        //Filtro rowFilter
        private void consultarPorNombre()
        {
            //lectura de la cadena de conexion en app.config
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();

            string sentencia = "SELECT * FROM Muestra";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);

                dt.DefaultView.RowFilter = string.Format("Descripcion LIKE '%{0}%'", tbBusquedaMuestras.Text);

                dgvMuestras.DataSource = dt;
                comando.Dispose();
                conexion.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede realizar la conexión del RowFilter.");
            }
        }
    }
}
