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
    public partial class FormGuardarCliente : Form
    {
        //lectura de la cadena de conexion en app.config
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        private DataGridViewRow fila;
        private string dni, nombre, telefono, direccion, poblacion;
        private int id_muestra;
        private bool modificar = false;

        //Propiedades para insertar
        public FormGuardarCliente()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarCliente.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Propiedades para modificar
        public FormGuardarCliente(DataGridViewRow fila)
        {
            InitializeComponent();
            this.fila = fila;
            modificar = true;
            cargarDatos();
            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarCliente.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Para mover el formulario desde la parte de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelGuardarAnalisis_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo que carga los datos en su componente correspondiente cuando seleccionamos una fila del dataGridView
        private void cargarDatos()
        {
            tbDniCliente.Text = fila.Cells[0].Value.ToString();
            tbNombreCliente.Text = fila.Cells[1].Value.ToString();
            tbTelefCliente.Text = fila.Cells[2].Value.ToString();
            tbDireccionCliente.Text = fila.Cells[3].Value.ToString();
            tbPoblacionCliente.Text = fila.Cells[4].Value.ToString();
            tbIdMuestraCliente.Text = fila.Cells[5].Value.ToString();
        }

        //Metodo cuando pulsamos el boton cerrar
        private void btnCerrarGuardarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos el boton guardar
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (comprobarCampos() && !modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                dni = tbDniCliente.Text;
                nombre = tbNombreCliente.Text;
                telefono = tbTelefCliente.Text;
                direccion = tbDireccionCliente.Text;
                poblacion = tbPoblacionCliente.Text;
                id_muestra = int.Parse(tbIdMuestraCliente.Text);

                try
                {
                    string sentencia = "INSERT INTO Cliente (Dni, Nombre, Telefono, Direccion, Poblacion, Id_Muestra)" +
                        "VALUES(@dni, @nombre, @telefono, @direccion, @poblacion, @idMuestra)";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@dni", dni);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@poblacion", poblacion);
                    comando.Parameters.AddWithValue("@idMuestra", id_muestra);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Cliente guardado.");
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se ha guardado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbDniCliente.Text = "";
                tbNombreCliente.Text = "";
                tbTelefCliente.Text = "";
                tbDireccionCliente.Text = "";
                tbPoblacionCliente.Text = "";
                tbIdMuestraCliente.Text = "";
            }
            else if (!modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }

            if (comprobarCampos() && modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                dni = tbDniCliente.Text;
                nombre = tbNombreCliente.Text;
                telefono = tbTelefCliente.Text;
                direccion = tbDireccionCliente.Text;
                poblacion = tbPoblacionCliente.Text;
                id_muestra = int.Parse(tbIdMuestraCliente.Text);

                try
                {
                    string sentencia = "UPDATE Cliente SET Nombre=@nombre, Telefono=@telefono, Direccion=@direccion, Poblacion=@poblacion, Id_Muestra=@idMuestra WHERE Dni=@dni";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@dni", dni);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@direccion", direccion);
                    comando.Parameters.AddWithValue("@poblacion", poblacion);
                    comando.Parameters.AddWithValue("@idMuestra", id_muestra);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Cliente modificado.");
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se ha modificado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbDniCliente.Text = "";
                tbNombreCliente.Text = "";
                tbTelefCliente.Text = "";
                tbDireccionCliente.Text = "";
                tbPoblacionCliente.Text = "";
                tbIdMuestraCliente.Text = "";
            }
            else if (modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }
        }

        //Metodo que comprueba que todos los campos esten rellenos
        private bool comprobarCampos()
        {
            if (tbDniCliente.TextLength == 0 || tbIdMuestraCliente.TextLength == 0 || tbNombreCliente.TextLength == 0 || tbTelefCliente.TextLength == 0 || tbDireccionCliente.TextLength == 0 || tbPoblacionCliente.TextLength == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
