using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void códigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codcli frm = new codcli();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadclientes frm = new cadclientes();
            frm.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadanimais frm = new cadanimais();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadprodutos frm = new cadprodutos();
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cadclientes frm = new cadclientes();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cadanimais frm = new cadanimais();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cadprodutos frm = new cadprodutos();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            codcli frm = new codcli();
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            codanimal frm = new codanimal();
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            codpro frm = new codpro();
            frm.Show();
        }

        private void códigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            codpro frm = new codpro();
            frm.Show();
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codanimal frm = new codanimal();
            frm.Show();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            desccli frm = new desccli();
            frm.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            descanimal frm = new descanimal();
            frm.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            descprod frm = new descprod();
            frm.Show();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desccli frm = new desccli();
            frm.Show();
        }

        private void nomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            descanimal frm = new descanimal();
            frm.Show();
        }

        private void descricaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            descprod frm = new descprod();
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            sobre frm = new sobre();
            frm.Show();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre frm = new sobre();
            frm.Show();
        }
    }
}
