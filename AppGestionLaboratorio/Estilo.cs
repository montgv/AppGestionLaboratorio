using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    class Estilo
    {
        private DataGridView formulario;

        public Estilo(DataGridView dataGridView)
        {
            this.formulario = dataGridView;
        }

        /*
         * En esta función estamos definiendo el estilo de todas las filas del datagridview
         */
        public void definirFilas(String colorSeleccionado, String valorPorDefecto, int tamanioFuente = 11, String fuente = "Comic Sans MS")
        {
            ColorConverter converter = new ColorConverter();

            DataGridViewCellStyle estiloFila;
            estiloFila = new DataGridViewCellStyle();
            estiloFila.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloFila.Font = new Font(fuente, tamanioFuente, FontStyle.Bold);
            estiloFila.NullValue = valorPorDefecto;
            estiloFila.SelectionBackColor = (Color)converter.ConvertFromString(colorSeleccionado);

            formulario.DefaultCellStyle = estiloFila;
            formulario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /*
         * En esta función estamos definiendo el estilo de la cabecera del datagridview
         */
        public void definirCabecera(String colorFondo, int tamanioFuente = 12, String fuente = "Comic Sans MS")
        {
            ColorConverter converter = new ColorConverter();

            DataGridViewCellStyle estiloCabecera;
            estiloCabecera = new DataGridViewCellStyle();
            estiloCabecera.BackColor = (Color)converter.ConvertFromString(colorFondo);
            estiloCabecera.ForeColor = Color.White;
            estiloCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estiloCabecera.Font = new Font(fuente, tamanioFuente, FontStyle.Bold);

            formulario.ColumnHeadersDefaultCellStyle = estiloCabecera;
            formulario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            formulario.ColumnHeadersHeight = 50;
            formulario.EnableHeadersVisualStyles = false;
        }
    }
}
