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
using System.Threading;

namespace APPControlePedidos2
{
    public partial class FrmLogin : Form
    {
        static string usuario;
        static string senha;
        Thread nt;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro cad = new FrmCadastro();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string SQL = "select * FROM Logins where Usuario=@Usuario and Senha=@Senha";
                String conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                OleDbCommand cmd = new OleDbCommand(SQL, con);

                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    autenticacao(dr["Usuario"].ToString(), dr["Senha"].ToString());
                    con.Close();
                    
                    MessageBox.Show("Logado com sucesso!");
                    this.Close();

                    nt = new Thread (novoform);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();

                }
                else
                {
                    MessageBox.Show("Erro ao logar!");
                }

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void novoform()
        {
            Application.Run(new FrmTelaPrincipal());
        }

        private static string GetUsuario()
        {
            return "Usuario: " + usuario + "\nSenha: " + senha;
        }

        private static void autenticacao(string usuario1, string senha1)
        {
            usuario = usuario1;
            senha = senha1;
        }
    }
}
