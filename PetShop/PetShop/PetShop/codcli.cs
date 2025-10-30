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
    public partial class codcli : Form
    {
        public codcli()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void codcli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientesBindingSource.Filter = "codigo=" + txtcodigo.Text;
        }
    }
}
