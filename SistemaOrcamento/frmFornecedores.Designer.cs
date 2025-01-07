namespace SistemaOrcamento
{
    partial class frmFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedores));
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCnpj = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            label5 = new Label();
            txtBuscar = new TextBox();
            dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 133);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 126);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 129);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "CNPJ";
            label2.Click += label2_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(526, 179);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(251, 27);
            txtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 186);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 182);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 5;
            label4.Text = "Endereço";
            label4.Click += label4_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(526, 126);
            txtCnpj.Mask = "00.000.000/0000-00";
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(251, 27);
            txtCnpj.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(147, 179);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(254, 27);
            txtTelefone.TabIndex = 7;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(215, 491);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(325, 491);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(436, 491);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(546, 491);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 45);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 13;
            label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(546, 42);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(193, 27);
            txtBuscar.TabIndex = 12;
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(75, 241);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(702, 223);
            dg.TabIndex = 14;
            // 
            // frmFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 542);
            Controls.Add(dg);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(txtTelefone);
            Controls.Add(txtCnpj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEndereco;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtCnpj;
        private MaskedTextBox txtTelefone;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label5;
        private TextBox txtBuscar;
        private DataGridView dg;
    }
}