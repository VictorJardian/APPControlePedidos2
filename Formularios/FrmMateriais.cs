using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace APPControlePedidos2
{
    public partial class FrmMaterais : Form
    {
        public FrmMaterais()
        {
            InitializeComponent();
            MessageBox.Show("Para Excluir algum Material click com o botao direito sobre o item", "Aviso");
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL = "select * from Materiais";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Materiais");

                dgMateriais.DataSource = ds.Tables["Materiais"];

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();
                string cod = dgMateriais.SelectedCells[0].Value.ToString();
                String SQL = "delete from Materiais where Codigo =" + cod;

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados apagados com sucesso!", "Aviso");
                btnConsultar_Click_1(sender, e);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
