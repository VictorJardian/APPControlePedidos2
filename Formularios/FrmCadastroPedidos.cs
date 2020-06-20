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
        string Concessionaria;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL;

                Concessionaria = cbConcessionaria.Text;

                if (Concessionaria == "Escelsa") 
                {
                    SQL = "Insert Into ListaPedidos(Cliente,Medidores,Concessionaria,TampaEDP,SobretampaEDP,CaixaMedidorEDP,PlacaSupDisjuntorEdpLight) Values ";
                    SQL += "('" + txtCliente.Text + "','" + txtMedidores.Text + "', '" + cbConcessionaria.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "')";

                    OleDbCommand cmd = new OleDbCommand(SQL, con);

                    cmd.ExecuteNonQuery();
                }

                else
                {
                    if(Concessionaria == "Light")
                    {
                        SQL = "Insert Into ListaPedidos(Cliente,Medidores,Concessionaria,TampaLight,SobretampaLight,CaixaMedidorLight,PlacaSupDisjuntorEdpLight) Values ";
                        SQL += "('" + txtCliente.Text + "','" + txtMedidores.Text + "', '" + cbConcessionaria.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "')";

                        OleDbCommand cmd = new OleDbCommand(SQL, con);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Concessionaria == "Energisa")
                        {
                            SQL = "Insert Into ListaPedidos(Cliente,Medidores,Concessionaria,TampaEnergisa,SobretampaEnergisa,CaixaMedidorEnergisa,PlacaSupDisjuntorEnergisa) Values ";
                            SQL += "('" + txtCliente.Text + "','" + txtMedidores.Text + "', '" + cbConcessionaria.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "','" + txtMedidores.Text + "')";

                            OleDbCommand cmd = new OleDbCommand(SQL, con);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
      
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
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
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
