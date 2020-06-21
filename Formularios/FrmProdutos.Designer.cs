namespace APPControlePedidos2
{
    partial class FrmRelatorios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgRelatorios = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bandoDadosAcessPROJETO02DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorios)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandoDadosAcessPROJETO02DataSet1BindingSource)).BeginInit();;
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dgRelatorios);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(11, 487);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(729, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // dgRelatorios
            // 
            this.dgRelatorios.AllowUserToAddRows = false;
            this.dgRelatorios.AllowUserToDeleteRows = false;
            this.dgRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelatorios.ContextMenuStrip = this.contextMenuStrip1;
            this.dgRelatorios.Location = new System.Drawing.Point(11, 25);
            this.dgRelatorios.Name = "dgRelatorios";
            this.dgRelatorios.ReadOnly = true;
            this.dgRelatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRelatorios.Size = new System.Drawing.Size(729, 446);
            this.dgRelatorios.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "Produtos";
            this.produtosBindingSource2.DataSource = this.bandoDadosAcessPROJETO02DataSet1BindingSource;
            // 
            // bandoDadosAcessPROJETO02DataSet1BindingSource
            // 
            this.bandoDadosAcessPROJETO02DataSet1BindingSource.Position = 0;
            // 
            // bandoDadosAcessPROJETO02DataSet1
            // 
            // 
            // listaPedidosBindingSource
            // 
            this.listaPedidosBindingSource.DataMember = "ListaPedidos";
            this.listaPedidosBindingSource.DataSource = this.bandoDadosAcessPROJETO02DataSet1BindingSource;
            // 
            // listaPedidosTableAdapter
            // 
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.bandoDadosAcessPROJETO02DataSet1BindingSource;
            // 
            // produtosTableAdapter
            // 
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            this.produtosBindingSource1.DataSource = this.bandoDadosAcessPROJETO02DataSet1BindingSource;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 623);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRelatorios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorios)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.listaPedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgRelatorios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.BindingSource bandoDadosAcessPROJETO02DataSet1BindingSource;
        private System.Windows.Forms.BindingSource listaPedidosBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
    }
}