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
    public partial class cadclientes : Form
    {
        public cadclientes()
        {
            InitializeComponent();
        }

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            nomeTextBox.Enabled = true;
            foneMaskedTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            cpfMaskedTextBox.Enabled = true;
            novo.Enabled = false;
            salvar.Enabled = true;
            Cancelar.Enabled = true;
            Excluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            nomeTextBox.Enabled = false;
            foneMaskedTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            cpfMaskedTextBox.Enabled = false;
            novo.Enabled = true;
            salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = true;
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cadclientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);

        }

        private void novo_Click(object sender, EventArgs e)
        {
            habilitar();
            clientesBindingSource.AddNew();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
            clientesTableAdapter.Fill(petshopDataSet.clientes);
            desabilitar();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            desabilitar();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            clientesBindingSource.RemoveCurrent();
            clientesBindingSource.EndEdit();
            clientesTableAdapter.Update(petshopDataSet.clientes);
        }
    }
}
