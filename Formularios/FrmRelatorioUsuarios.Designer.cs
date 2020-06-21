namespace APPControlePedidos2
{
    partial class FrmRelatorioUsuarios
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
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new APPControlePedidos2.Resources.DataSet1();
            this.loginsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new APPControlePedidos2.Resources.DataSet1TableAdapters.LoginsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loginsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource1
            // 
            this.loginsBindingSource1.DataMember = "Logins";
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dataset_tbUsuarios";
            reportDataSource1.Value = this.loginsBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPControlePedidos2.Formularios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(735, 516);
            this.reportViewer1.TabIndex = 0;
            // 
            // loginsBindingSource2
            // 
            this.loginsBindingSource2.DataMember = "Logins";
            this.loginsBindingSource2.DataSource = this.dataSet1;
            // 
            // FrmRelatorioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 623);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRelatorioUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Usuarios";
            this.Load += new System.EventHandler(this.FrmRelatorioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource loginsBindingSource1;
        private Resources.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private Resources.DataSet1TableAdapters.LoginsTableAdapter loginsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource loginsBindingSource2;
    }
}