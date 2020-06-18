using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace APPControlePedidos2
{
    public OleDbConnection con = new OleDbConnection();

    class Conexao
    {
        public void conectar()
        {
            con.con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\win10\Desktop\BandoDadosAcessPROJETO02.mdb";

        }
    }
}
