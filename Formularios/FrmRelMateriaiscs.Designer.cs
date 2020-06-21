namespace APPControlePedidos2.Formularios
{
    partial class FrmRelMateriais
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bandoDadosAcessPROJETO02DataSet = new APPControlePedidos2.BandoDadosAcessPROJETO02DataSet();
            this.materiaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaisTableAdapter = new APPControlePedidos2.BandoDadosAcessPROJETO02DataSetTableAdapters.MateriaisTableAdapter();
            this.listaPedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidosTableAdapter = new APPControlePedidos2.BandoDadosAcessPROJETO02DataSetTableAdapters.ListaPedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bandoDadosAcessPROJETO02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listaPedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPControlePedidos2.Formularios.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(951, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // bandoDadosAcessPROJETO02DataSet
            // 
            this.bandoDadosAcessPROJETO02DataSet.DataSetName = "BandoDadosAcessPROJETO02DataSet";
            this.bandoDadosAcessPROJETO02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaisBindingSource
            // 
            this.materiaisBindingSource.DataMember = "Materiais";
            this.materiaisBindingSource.DataSource = this.bandoDadosAcessPROJETO02DataSet;
            // 
            // materiaisTableAdapter
            // 
            this.materiaisTableAdapter.ClearBeforeFill = true;
            // 
            // listaPedidosBindingSource
            // 
            this.listaPedidosBindingSource.DataMember = "ListaPedidos";
            this.listaPedidosBindingSource.DataSource = this.bandoDadosAcessPROJETO02DataSet;
            // 
            // listaPedidosTableAdapter
            // 
            this.listaPedidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 619);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelMateriais";
            this.ShowIcon = false;
            this.Text = "Relatório de Materiais";
            this.Load += new System.EventHandler(this.FrmRelMateriais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandoDadosAcessPROJETO02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BandoDadosAcessPROJETO02DataSet bandoDadosAcessPROJETO02DataSet;
        private System.Windows.Forms.BindingSource materiaisBindingSource;
        private BandoDadosAcessPROJETO02DataSetTableAdapters.MateriaisTableAdapter materiaisTableAdapter;
        private System.Windows.Forms.BindingSource listaPedidosBindingSource;
        private BandoDadosAcessPROJETO02DataSetTableAdapters.ListaPedidosTableAdapter listaPedidosTableAdapter;
    }
}