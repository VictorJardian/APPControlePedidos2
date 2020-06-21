using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using APPControlePedidos2.Formularios;
using APPControlePedidos2.Relatorios;

namespace APPControlePedidos2
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPedidos frm = new FrmCadastroPedidos();
            frm.Show();
        }

        private void materiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProdutos frm = new FrmCadastroProdutos();
            frm.Show();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaPedidos frm = new FrmListaPedidos();
            frm.Show();
        }

        private void materiaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMaterais frm = new FrmMaterais();
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelUsuarios frm = new FrmRelUsuarios();
            frm.Show();
        }

        private void materaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelMateriais frm = new FrmRelMateriais();
            frm.Show();
        }
    }
}
