using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    public partial class FormGuardarMuestra : Form
    {
        //lectura de la cadena de conexion en app.config
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        private DataGridViewRow fila;
        private string descripcion, fechaRecepcion, cantidad;
        private int id;
        private bool modificar = false;

        //Propiedades para insertar
        public FormGuardarMuestra()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarMuestra.FlatStyle = FlatStyle.Flat;
            btnGuardarMuestra.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Propiedades para modificar
        public FormGuardarMuestra(DataGridViewRow fila)
        {
            InitializeComponent();
            this.fila = fila;
            modificar = true;
            cargarDatos();
            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarMuestra.FlatStyle = FlatStyle.Flat;
            btnGuardarMuestra.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Para mover el formulario desde la parte de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelGuardarMuestra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo que carga los datos en su componente correspondiente cuando seleccionamos una fila del dataGridView
        private void cargarDatos()
        {
            tbIdMuestra.Text = fila.Cells[0].Value.ToString();
            tbDescripcionMuestra.Text = fila.Cells[1].Value.ToString();
            dtpFechaRecepcionMuestra.Text = fila.Cells[2].Value.ToString();
            tbCantidadMuestra.Text = fila.Cells[3].Value.ToString();
        }

        //Metodo cuando pulsamos la imagen de cerrar
        private void btnCerrarAniadirMuestra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos el boton guardar
        private void btnGuardarMuestra_Click(object sender, EventArgs e)
        {
            if (comprobarCampos() && !modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                id = int.Parse(tbIdMuestra.Text);
                descripcion = tbDescripcionMuestra.Text;
                fechaRecepcion = Convert.ToString(dtpFechaRecepcionMuestra.Value.Date);
                cantidad = tbCantidadMuestra.Text;

                try
                {
                    string sentencia = "INSERT INTO Muestra (Id, Descripcion, Fecha_Recepcion, Cantidad)" +
                        "VALUES(@id, @descripcion, @fechaRecepcion, @cantidad)";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@fechaRecepcion", fechaRecepcion);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Muestra guardada.");
                    }
                    else
                    {
                        MessageBox.Show("La muestra no se ha guardado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbIdMuestra.Text = "";
                tbDescripcionMuestra.Text = "";
                dtpFechaRecepcionMuestra.Text = "";
                tbCantidadMuestra.Text = "";
            }
            else if(!modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }

            if (comprobarCampos() && modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                id = int.Parse(tbIdMuestra.Text);
                descripcion = tbDescripcionMuestra.Text;
                fechaRecepcion = Convert.ToString(dtpFechaRecepcionMuestra.Value.Date);
                cantidad = tbCantidadMuestra.Text;

                try
                {
                    string sentencia = "UPDATE Muestra SET Descripcion=@descripcion, Fecha_Recepcion=@fechaRecepcion, Cantidad=@cantidad WHERE Id=@id";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@fechaRecepcion", fechaRecepcion);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Muestra modificada.");
                    }
                    else
                    {
                        MessageBox.Show("La muestra no se ha modificado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbIdMuestra.Text = "";
                tbDescripcionMuestra.Text = "";
                dtpFechaRecepcionMuestra.Text = "";
                tbCantidadMuestra.Text = "";
            }
            else if (modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }
        }

        //Metodo que comprueba que todos los campos esten rellenos
        private bool comprobarCampos()
        {
            if (tbIdMuestra.TextLength == 0 || tbDescripcionMuestra.TextLength == 0 || tbCantidadMuestra.TextLength == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
