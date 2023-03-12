using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

            //Cambiamos el color de fondo, el color y el tipo de la letra al formulario
            BackColor = Color.FromArgb(228, 251, 251);
            Font = new Font("Comic Sans MS", 12, FontStyle.Bold);

            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }

        //Metodo para abrir un form dentro del panel contenedor
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //Metodo para mostrar el formulario del login al iniciar
        private void MostrarFormLogin()
        {
            AbrirFormEnPanel(new FormLogin());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogin();
        }

        //Para mover el formulario desde la parte de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Botones de la barra de titulo
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrar?", "CERRAR APLICACIÓN", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo que nos muestra la hora y la fecha
        private void timer_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Metodo que abre el formClientes cuando pulsamos en el menuClientes
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormClientes());
        }

        //Metodo que abre el formMuestras cuando pulsamos en el menuMuestras
        private void btnMenuMuestras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMuestras());
        }

        //Metodo que abre el formAnalisis cuando pulsamos en el menuAnalisis
        private void btnMenuAnalisis_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAnalisis());
        }

        //Metodo que abre el formInformes cuando pulsamos en el menuInformes
        private void btnMenuInformes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInformes());
        }

        //Metodo que abre el formFacturas cuando pulsamos en el menuFacturas
        private void btnMenuFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormFacturas());
        }

    }
}
