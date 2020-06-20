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
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\win10\source\repos\APPControlePedidos2\Resources\BandoDadosAcessPROJETO02.mdb";
                OleDbConnection con = new OleDbConnection(conexao);
                con.Open();

                String SQL = "select * from Material";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Material");

                dgRelatorios.DataSource = ds.Tables["Material"];

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
