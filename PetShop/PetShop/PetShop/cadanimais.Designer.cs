namespace PetShop
{
    partial class cadanimais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label fotoLabel;
            this.petshopDataSet = new PetShop.petshopDataSet();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new PetShop.petshopDataSetTableAdapters.animaisTableAdapter();
            this.tableAdapterManager = new PetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.novo = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            codigoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            codigoLabel.Location = new System.Drawing.Point(22, 15);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(76, 25);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "codigo:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            descricaoLabel.Location = new System.Drawing.Point(22, 48);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(102, 25);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "descricao:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            tipoLabel.Location = new System.Drawing.Point(22, 81);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(49, 25);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "tipo:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            data_cadastroLabel.Location = new System.Drawing.Point(22, 114);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(136, 25);
            data_cadastroLabel.TabIndex = 7;
            data_cadastroLabel.Text = "data cadastro:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            fotoLabel.Location = new System.Drawing.Point(677, 12);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(50, 25);
            fotoLabel.TabIndex = 9;
            fotoLabel.Text = "foto:";
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "animais";
            this.animaisBindingSource.DataSource = this.petshopDataSet;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animaisTableAdapter = this.animaisTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "codigo", true));
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.codigoTextBox.Location = new System.Drawing.Point(179, 13);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(465, 27);
            this.codigoTextBox.TabIndex = 2;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "descricao", true));
            this.descricaoTextBox.Enabled = false;
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descricaoTextBox.Location = new System.Drawing.Point(179, 46);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(465, 27);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "tipo", true));
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tipoTextBox.Location = new System.Drawing.Point(179, 79);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(465, 27);
            this.tipoTextBox.TabIndex = 6;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animaisBindingSource, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Enabled = false;
            this.data_cadastroDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(179, 112);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(465, 27);
            this.data_cadastroDateTimePicker.TabIndex = 8;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animaisBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(733, 12);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(130, 130);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.Location = new System.Drawing.Point(27, 161);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.Size = new System.Drawing.Size(543, 220);
            this.animaisDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_cadastro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(733, 282);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 40);
            this.Excluir.TabIndex = 18;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Enabled = false;
            this.Cancelar.Location = new System.Drawing.Point(618, 282);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 40);
            this.Cancelar.TabIndex = 17;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Enabled = false;
            this.salvar.Location = new System.Drawing.Point(733, 223);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(100, 40);
            this.salvar.TabIndex = 16;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(618, 223);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(100, 40);
            this.novo.TabIndex = 15;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // foto
            // 
            this.foto.Enabled = false;
            this.foto.Location = new System.Drawing.Point(682, 99);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(45, 43);
            this.foto.TabIndex = 19;
            this.foto.Text = "Foto";
            this.foto.UseVisualStyleBackColor = true;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cadanimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 403);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.animaisDataGridView);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(data_cadastroLabel);
            this.Controls.Add(this.data_cadastroDateTimePicker);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Name = "cadanimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Animais";
            this.Load += new System.EventHandler(this.cadanimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private petshopDataSetTableAdapters.animaisTableAdapter animaisTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}