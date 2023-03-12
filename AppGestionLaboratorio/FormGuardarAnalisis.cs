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
    public partial class FormGuardarAnalisis : Form
    {
        //lectura de la cadena de conexion en app.config
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        private DataGridViewRow fila;
        private int id, idMuestra;
        private string nombre, fecha, analista;
        private float lecturaPrimera, lecturaSegunda, lecturaResultado, precio;
        private bool modificar = false;

        //Propiedades para insertar
        public FormGuardarAnalisis()
        {
            InitializeComponent();

            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarAnalisis.FlatStyle = FlatStyle.Flat;
            btnGuardarAnalisis.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Para mover el formulario desde la parte de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Propiedades para modificar
        public FormGuardarAnalisis(DataGridViewRow fila)
        {
            InitializeComponent();
            this.fila = fila;
            modificar = true;
            cargarDatos();
            //Cambiamos el color de fondo y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
            //Cambiamos los botones
            btnGuardarAnalisis.FlatStyle = FlatStyle.Flat;
            btnGuardarAnalisis.BackColor = Color.FromArgb(150, 196, 196);
        }

        //Metodo que carga los datos en su componente correspondiente cuando seleccionamos una fila del dataGridView
        private void cargarDatos()
        {
            tbIdAnalisis.Text = fila.Cells[0].Value.ToString();
            tbNombreAnalisis.Text = fila.Cells[1].Value.ToString();
            dtpFechaAnalisis.Text = fila.Cells[2].Value.ToString();
            tbAnalistaAnalisis.Text = fila.Cells[3].Value.ToString();
            tbLectura1Analisis.Text = fila.Cells[4].Value.ToString();
            tbLectura2Analisis.Text = fila.Cells[5].Value.ToString();
            lbResultadoAnalisis.Text = fila.Cells[6].Value.ToString();
            tbPrecioAnalisis.Text = fila.Cells[7].Value.ToString();
            tbIdMuestraAnalisis.Text = fila.Cells[8].Value.ToString();
        }

        //Eve
        private void btnCerrarAniadirMuestra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo cuando pulsamos el boton guardar
        private void btnGuardarAnalisis_Click(object sender, EventArgs e)
        {
            if (comprobarCampos() && !modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                id = int.Parse(tbIdAnalisis.Text);
                nombre = tbNombreAnalisis.Text;
                fecha = Convert.ToString(dtpFechaAnalisis.Value.Date);
                analista = tbAnalistaAnalisis.Text;
                lecturaPrimera = float.Parse(tbLectura1Analisis.Text);
                lecturaSegunda = float.Parse(tbLectura2Analisis.Text);
                lecturaResultado = float.Parse(lbResultadoAnalisis.Text);
                precio = float.Parse(tbPrecioAnalisis.Text);
                idMuestra = int.Parse(tbIdMuestraAnalisis.Text);

                try
                {
                    string sentencia = "INSERT INTO Analisis (Id, Nombre, Fecha, Analista, Lectura_Primera, Lectura_Segunda, Resultado, Precio, Id_Muestra)" +
                        "VALUES(@id, @nombre, @fecha, @analista, @lecturaPrimera, @lecturaSegunda, @resultado, @precio, @idMuestra)";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@analista", analista);
                    comando.Parameters.AddWithValue("@lecturaPrimera", lecturaPrimera);
                    comando.Parameters.AddWithValue("@lecturaSegunda", lecturaSegunda);
                    comando.Parameters.AddWithValue("@resultado", lecturaResultado);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@idMuestra", idMuestra);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Análisis guardado.");
                    }
                    else
                    {
                        MessageBox.Show("El análisis no se ha guardado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbIdAnalisis.Text = "";
                tbIdMuestraAnalisis.Text = "";
                tbNombreAnalisis.Text = "";
                dtpFechaAnalisis.Text = "";
                tbAnalistaAnalisis.Text = "";
                tbLectura1Analisis.Text = "";
                tbLectura2Analisis.Text = "";
                lbResultadoAnalisis.Text = "Resultado";
                tbPrecioAnalisis.Text = "";
            }
            else if (!modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }

            if (comprobarCampos() && modificar)
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);

                id = int.Parse(tbIdAnalisis.Text);
                nombre = tbNombreAnalisis.Text;
                fecha = Convert.ToString(dtpFechaAnalisis.Value.Date);
                analista = tbAnalistaAnalisis.Text;
                lecturaPrimera = float.Parse(tbLectura1Analisis.Text);
                lecturaSegunda = float.Parse(tbLectura2Analisis.Text);
                lecturaResultado = float.Parse(lbResultadoAnalisis.Text);
                precio = float.Parse(tbPrecioAnalisis.Text);
                idMuestra = int.Parse(tbIdMuestraAnalisis.Text);

                try
                {
                    string sentencia = "UPDATE Analisis SET Nombre=@nombre, Fecha=@fecha, Analista=@analista, Lectura_Primera=@lecturaPrimera, " +
                        "Lectura_Segunda=@lecturaSegunda, Resultado=@lecturaResultado, Precio=@precio, Id_Muestra=@idMuestra WHERE Id=@id";

                    SqlCommand comando = new SqlCommand(sentencia, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@analista", analista);
                    comando.Parameters.AddWithValue("@lecturaPrimera", lecturaPrimera);
                    comando.Parameters.AddWithValue("@lecturaSegunda", lecturaSegunda);
                    comando.Parameters.AddWithValue("@resultado", lecturaResultado);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@idMuestra", idMuestra);
                    conexion.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Análisis modificado.");
                    }
                    else
                    {
                        MessageBox.Show("El análisis no se ha modificado.");
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbIdAnalisis.Text = "";
                tbIdMuestraAnalisis.Text = "";
                tbNombreAnalisis.Text = "";
                dtpFechaAnalisis.Text = "";
                tbAnalistaAnalisis.Text = "";
                tbLectura1Analisis.Text = "";
                tbLectura2Analisis.Text = "";
                lbResultadoAnalisis.Text = "Resultado";
                tbPrecioAnalisis.Text = "";
            }
            else if (modificar)
            {
                MessageBox.Show("Debes de rellenar todos los campos.");
            }
        }

        //Metodo que comprueba que todos los campos esten rellenos
        private bool comprobarCampos()
        {
            if (tbIdAnalisis.TextLength == 0 || tbNombreAnalisis.TextLength == 0 || dtpFechaAnalisis.Text == "" || tbAnalistaAnalisis.TextLength == 0 || tbLectura1Analisis.TextLength == 0 || tbLectura2Analisis.TextLength == 0 || tbPrecioAnalisis.TextLength == 0 || tbIdMuestraAnalisis.TextLength == 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Metodo que calcula la media de las dos lecturas cuando pulsamos el boton caalcular
        private void btCalcularAnalisis_Click(object sender, EventArgs e)
        {
            if (tbLectura1Analisis.TextLength == 0 || tbLectura2Analisis.TextLength == 0)
            {
                MessageBox.Show("Debes introducir los valores de lectura.");
            } else
            {
                lbResultadoAnalisis.Text = Convert.ToString((float.Parse(tbLectura1Analisis.Text) + float.Parse(tbLectura2Analisis.Text)) / 2);
            }
        }
    }
}
