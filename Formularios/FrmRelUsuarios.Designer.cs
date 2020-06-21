namespace APPControlePedidos2.Relatorios
{
    partial class FrmRelUsuarios
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
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new APPControlePedidos2.BandoDadosAcessPROJETO02DataSetTableAdapters.LoginsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bandoDadosAcessPROJETO02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dataset_tbUsuario";
            reportDataSource1.Value = this.loginsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPControlePedidos2.Formularios.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(599, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // bandoDadosAcessPROJETO02DataSet
            // 
            this.bandoDadosAcessPROJETO02DataSet.DataSetName = "BandoDadosAcessPROJETO02DataSet";
            this.bandoDadosAcessPROJETO02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.bandoDadosAcessPROJETO02DataSet;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 578);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelUsuarios";
            this.ShowIcon = false;
            this.Text = "Relatório de Usuários";
            this.Load += new System.EventHandler(this.FrmRelUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandoDadosAcessPROJETO02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BandoDadosAcessPROJETO02DataSet bandoDadosAcessPROJETO02DataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private BandoDadosAcessPROJETO02DataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
    }
}