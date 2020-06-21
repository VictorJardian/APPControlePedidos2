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
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        public String Codigo;

        private void button1_Click(object sender, EventArgs e)
        {
            String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
            OleDbConnection con = new OleDbConnection(conexao);
            con.Open();

            String SQL;

            SQL = "Insert Into Produtos(Descricao) Values ";
            SQL += "('" + txtNomeProd.Text + "')";

            OleDbCommand cmd = new OleDbCommand(SQL, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Produto cadastrado com sucesso!", "Aviso");

            txtNomeProd.Clear();

            con.Close();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL;

                SQL = "update ListaPedidos set Produtos = '" + txtNomeProd.Text + "',";
                SQL += "where Codigo = " + Codigo;

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produtos alterados com sucesso!", "Aviso");

                txtNomeProd.Clear();

                con.Close();
                this.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
