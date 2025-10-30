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
    public partial class cadprodutos : Form
    {
        public cadprodutos()
        {
            InitializeComponent();
        }

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            quantidadeTextBox.Enabled = true;
            precoTextBox.Enabled = true;
            fornecedorTextBox.Enabled = true;
            novo.Enabled = false;
            salvar.Enabled = true;
            Cancelar.Enabled = true;
            Excluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            descricaoTextBox.Enabled = false;
            quantidadeTextBox.Enabled = false;
            precoTextBox.Enabled = false;
            fornecedorTextBox.Enabled = false;
            novo.Enabled = true;
            salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = true;
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cadprodutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.petshopDataSet.produtos);

        }

        private void novo_Click(object sender, EventArgs e)
        {
            habilitar();
            produtosBindingSource.AddNew();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.CancelEdit();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(petshopDataSet.produtos);
            produtosTableAdapter.Fill(petshopDataSet.produtos);
            desabilitar();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            produtosBindingSource.RemoveCurrent();
            produtosBindingSource.EndEdit();
            produtosTableAdapter.Update(petshopDataSet.produtos);
        }
    }
}
