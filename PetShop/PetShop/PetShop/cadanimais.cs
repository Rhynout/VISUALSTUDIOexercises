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
    public partial class cadanimais : Form
    {
        public cadanimais()
        {
            InitializeComponent();
        }

        void habilitar()
        {
            codigoTextBox.Enabled = true;
            descricaoTextBox.Enabled = true;
            tipoTextBox.Enabled = true;
            data_cadastroDateTimePicker.Enabled = true;
            foto.Enabled = true;
            novo.Enabled = false;
            salvar.Enabled = true;
            Cancelar.Enabled = true;
            Excluir.Enabled = false;
        }

        void desabilitar()
        {
            codigoTextBox.Enabled = false;
            descricaoTextBox.Enabled = false;
            tipoTextBox.Enabled = false;
            data_cadastroDateTimePicker.Enabled = false;
            foto.Enabled = false;
            novo.Enabled = true;
            salvar.Enabled = false;
            Cancelar.Enabled = false;
            Excluir.Enabled = true;
        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void cadanimais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.animais' table. You can move, or remove it, as needed.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void novo_Click(object sender, EventArgs e)
        {
            habilitar();
            animaisBindingSource.AddNew();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.CancelEdit();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            animaisBindingSource.EndEdit();
            animaisTableAdapter.Update(petshopDataSet.animais);
            animaisTableAdapter.Fill(petshopDataSet.animais);
            desabilitar();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            animaisBindingSource.RemoveCurrent();
            animaisBindingSource.EndEdit();
            animaisTableAdapter.Update(petshopDataSet.animais);
        }

        private void foto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotoPictureBox.Image = System.Drawing.Bitmap.FromFile(openFileDialog1.FileName);
        }
    }
}
