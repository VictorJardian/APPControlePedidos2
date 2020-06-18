﻿using System;
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

namespace APPControlePedidos2
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPedidos frm = new FrmCadastroPedidos();
            frm.Show();
        }

        private void listaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaPedidos frm = new FrmListaPedidos();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
