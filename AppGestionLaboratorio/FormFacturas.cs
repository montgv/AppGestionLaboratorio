using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionLaboratorio
{
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string dniClienteBuscar = this.tbDniClienteBuscar.Text;

            // TODO: esta línea de código carga datos en la tabla 'dataSetLaboratorio.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.FillBy(this.dataSetLaboratorio.Factura, dniClienteBuscar);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        }

        private void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            //Guardamos el id del comercial
            var dniCliente = e.Parameters["dniCliente"].Values.First();

            //Creamos un dataset y lo rellenamos con la consulta
            DataSetLaboratorio.FacturaDataTable factura = new DataSetLaboratorio.FacturaDataTable();
            this.facturaTableAdapter.FillBy(factura, dniCliente);
            //Enlazamos con el DataSet del conjunto de datos del subinforme
            e.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)factura));
        }
    }
}
