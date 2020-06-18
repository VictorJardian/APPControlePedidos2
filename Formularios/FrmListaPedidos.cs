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

namespace APPControlePedidos2.Formularios
{
    public partial class FrmListaPedidos : Form
    {
        public FrmListaPedidos()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL = "select * from ListaPedidos";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "ListaPedidos");

                dgResultado.DataSource = ds.Tables["ListaPedidos"];

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPedidos frm = new FrmCadastroPedidos();
            frm.Codigo = dgResultado.SelectedCells[0].Value.ToString();
            frm.txtCliente.Text = dgResultado.SelectedCells[1].Value.ToString();
            frm.txtMedidores.Text = dgResultado.SelectedCells[2].Value.ToString();
            frm.cbConcessionaria.Text = dgResultado.SelectedCells[3].Value.ToString();
            frm.btnSalvar.Visible = false;
            frm.btnAlterar.Visible = true;

            frm.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();
                string cod = dgResultado.SelectedCells[0].Value.ToString();
                String SQL = "delete from ListaPedidos where Codigo =" + cod;

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados apagados com sucesso!");
                btnConsulta_Click(sender, e);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
