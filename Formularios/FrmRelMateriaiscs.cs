using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPControlePedidos2.Formularios
{
    public partial class FrmRelMateriais : Form
    {
        public FrmRelMateriais()
        {
            InitializeComponent();
            MessageBox.Show("Caso não atualize verifique se está conectado com o banco de dados","Aviso");
        }

        private void FrmRelMateriais_Load(object sender, EventArgs e)
        {
            this.listaPedidosTableAdapter.Fill(this.bandoDadosAcessPROJETO02DataSet.ListaPedidos);
            this.materiaisTableAdapter.Fill(this.bandoDadosAcessPROJETO02DataSet.Materiais);
            this.reportViewer1.RefreshReport();
        }
    }
}
