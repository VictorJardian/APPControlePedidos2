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
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
            MessageBox.Show("Ao clicar com o botão direito sobre a tabela podera Excluir itens", "Aviso");
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL = "select * from Produtos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Produtos");

                dgRelatorios.DataSource = ds.Tables["Produtos"];

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
                    string cod = dgRelatorios.SelectedCells[0].Value.ToString();
                    String SQL = "delete from Produtos where Codigo =" + cod;

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
