using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPControlePedidos2.Formularios
{
    public partial class FrmCadastroPedidos : Form
    {
        public FrmCadastroPedidos()
        {
            InitializeComponent();
        }

        public string Codigo;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL;

                SQL = "Insert Into ListaPedidos(Cliente,Medidores,Concessionaria) Values ";
                SQL += "('" + txtCliente.Text + "','" + txtMedidores.Text + "', '" + cbConcessionaria.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso!");

                txtCliente.Clear();
                txtMedidores.Clear();
                cbConcessionaria.SelectedIndex = -1;

                con.Close();
                this.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL;

                SQL = "update ListaPedidos set Cliente = '" + txtCliente.Text + "',";
                SQL += "Medidores = '" + txtMedidores.Text + "' ";
                SQL += "Concessionaria = '" + cbConcessionaria + "' ";
                SQL += "where Codigo = " + Codigo;

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");

                txtCliente.Clear();
                txtMedidores.Clear();
                cbConcessionaria.SelectedIndex = -1;

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
