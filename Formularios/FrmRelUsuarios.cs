using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPControlePedidos2.Relatorios
{
    public partial class FrmRelUsuarios : Form
    {
        public FrmRelUsuarios()
        {
            InitializeComponent();
            MessageBox.Show("Caso não atualize verifique se está conectado com o banco de dados", "Aviso");
        }

        private void FrmRelUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bandoDadosAcessPROJETO02DataSet.Logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.bandoDadosAcessPROJETO02DataSet.Logins);

            this.reportViewer1.RefreshReport();
        }
    }
}
