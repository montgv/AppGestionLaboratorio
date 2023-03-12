using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    public partial class FormClientes : Form
    {
        ArrayList celdas = new ArrayList();

        public FormClientes()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnAniadirClientes.FlatStyle = FlatStyle.Flat;
            btnAniadirClientes.BackColor = Color.FromArgb(150, 196, 196);
            btnModificarClientes.FlatStyle = FlatStyle.Flat;
            btnModificarClientes.BackColor = Color.FromArgb(150, 196, 196);
            btDerClientes.FlatStyle = FlatStyle.Flat;
            btDerClientes.BackColor = Color.FromArgb(150, 196, 196);
            btIzqClientes.FlatStyle = FlatStyle.Flat;
            btIzqClientes.BackColor = Color.FromArgb(150, 196, 196);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            conectar();

            Estilo estilo = new Estilo(this.dgvClientes);

            //Introducimos los diferetentes estilos
            estilo.definirCabecera("#315d5d");
            estilo.definirFilas("#96c4c4", "**********");
            dgvClientes.BackgroundColor = Color.FromArgb(228, 251, 251);

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgvClientes.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        //conectamos con la base de datos
        private void conectar()
        {
            //lectura de la cadena de conexion en app.config
            string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();

            string sentencia = "SELECT * FROM Cliente ORDER BY Dni";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgvClientes.DataSource = dt;
                comando.Dispose();
                conexion.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

        //Metodo cuando pulsamos en la imagen de salir de debajo de Clientes
        private void btnCerrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos en el boton añadir
        private void btnAniadirClientes_Click(object sender, EventArgs e)
        {
            FormGuardarCliente guardarCliente = new FormGuardarCliente();
            guardarCliente.ShowDialog();
            conectar();
        }

        //Metodo cuando pulsamos en el boton modificar
        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvClientes.CurrentRow;
                
                FormGuardarCliente cliente = new FormGuardarCliente(fila);

                cliente.ShowDialog();

                conectar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }

        //Evento que al cambiar el texto del textBox filtra
        private void tbBusquedaSelectiva_TextChanged(object sender, EventArgs e)
        {
            celdas.Clear();
            buscarCoincidencias();

            if (celdas.Count > 0)
            {
                dgvClientes.CurrentCell = (DataGridViewCell)celdas[0];
            }
            else
            {
                dgvClientes.CurrentCell = dgvClientes[0, 0];
            }
        }

        //Metodo para buscar coincidencias dentro del dataGridView
        private void buscarCoincidencias()
        {
            for (int i = 0; i < dgvClientes.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell celda in dgvClientes.Rows[i].Cells)
                {
                    if (tbBusquedaSelectiva.Text != "" && celda.Value.ToString().Contains(tbBusquedaSelectiva.Text))
                    {
                        celdas.Add(celda);
                        celda.Style.BackColor = Color.FromArgb(150, 196, 196);
                    }
                    else
                    {
                        celda.Style.BackColor = Color.White;
                    }
                }
            }
        }

        //Evento que se produce cuando pulsamos en el boton de la izquierda
        private void btIzqClientes_Click(object sender, EventArgs e)
        {
            if (celdas.Count > 0)
            {
                int indice = celdas.IndexOf(dgvClientes.CurrentCell);

                if (indice > 0)
                {
                    dgvClientes.CurrentCell = (DataGridViewCell)celdas[indice - 1];
                }
            }
        }

        //Evento que se produce cuando pulsamos en el boton de la derecha
        private void btDerClientes_Click(object sender, EventArgs e)
        {
            if (celdas.Count > 0)
            {
                int indice = celdas.IndexOf(dgvClientes.CurrentCell);

                if (indice < celdas.Count - 1)
                {
                    dgvClientes.CurrentCell = (DataGridViewCell)celdas[indice + 1];
                }
            }
        }
    }
}
