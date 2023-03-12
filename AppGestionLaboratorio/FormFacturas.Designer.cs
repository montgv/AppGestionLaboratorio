namespace AppGestionLaboratorio
{
    partial class FormFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLaboratorio = new AppGestionLaboratorio.DataSetLaboratorio();
            this.facturaTableAdapter = new AppGestionLaboratorio.DataSetLaboratorioTableAdapters.FacturaTableAdapter();
            this.lbBuscadorDniCliente = new System.Windows.Forms.Label();
            this.tbDniClienteBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btnCerrarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppGestionLaboratorio.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(762, 318);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.dataSetLaboratorio;
            // 
            // dataSetLaboratorio
            // 
            this.dataSetLaboratorio.DataSetName = "DataSetLaboratorio";
            this.dataSetLaboratorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // lbBuscadorDniCliente
            // 
            this.lbBuscadorDniCliente.AutoSize = true;
            this.lbBuscadorDniCliente.Location = new System.Drawing.Point(39, 40);
            this.lbBuscadorDniCliente.Name = "lbBuscadorDniCliente";
            this.lbBuscadorDniCliente.Size = new System.Drawing.Size(161, 20);
            this.lbBuscadorDniCliente.TabIndex = 7;
            this.lbBuscadorDniCliente.Text = "Buscar por IdCliente: ";
            // 
            // tbDniClienteBuscar
            // 
            this.tbDniClienteBuscar.Location = new System.Drawing.Point(233, 34);
            this.tbDniClienteBuscar.Name = "tbDniClienteBuscar";
            this.tbDniClienteBuscar.Size = new System.Drawing.Size(158, 26);
            this.tbDniClienteBuscar.TabIndex = 8;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(440, 26);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(126, 40);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btnCerrarFactura
            // 
            this.btnCerrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFactura.FlatAppearance.BorderSize = 0;
            this.btnCerrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFactura.Image = global::AppGestionLaboratorio.Properties.Resources.ic_cerrar1;
            this.btnCerrarFactura.Location = new System.Drawing.Point(704, 16);
            this.btnCerrarFactura.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCerrarFactura.Name = "btnCerrarFactura";
            this.btnCerrarFactura.Size = new System.Drawing.Size(70, 62);
            this.btnCerrarFactura.TabIndex = 10;
            this.btnCerrarFactura.UseVisualStyleBackColor = true;
            this.btnCerrarFactura.Click += new System.EventHandler(this.btnCerrarFactura_Click);
            // 
            // FormFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 425);
            this.Controls.Add(this.btnCerrarFactura);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbDniClienteBuscar);
            this.Controls.Add(this.lbBuscadorDniCliente);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturas";
            this.Text = "FormFacturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLaboratorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetLaboratorio dataSetLaboratorio;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DataSetLaboratorioTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.Label lbBuscadorDniCliente;
        private System.Windows.Forms.TextBox tbDniClienteBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btnCerrarFactura;
    }
}