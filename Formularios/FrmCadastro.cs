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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL;

                SQL = "Insert Into logins(Usuario,senha) Values ";
                SQL += "('" + txtUsuario.Text + "','" + txtSenha.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL,con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso!");

                txtUsuario.Clear();
                txtSenha.Clear();

                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        
    }
}
