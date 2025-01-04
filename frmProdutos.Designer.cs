namespace SistemaOrcamento
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            dg = new DataGridView();
            label5 = new Label();
            txtBuscar = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            label4 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(86, 232);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(702, 232);
            dg.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 15);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 28;
            label5.Text = "Buscar";
            label5.Click += label5_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(595, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(193, 27);
            txtBuscar.TabIndex = 27;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(557, 485);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 26;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(447, 485);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(336, 485);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(226, 485);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 127);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 20;
            label4.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 131);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 19;
            label3.Text = "Descrição";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(531, 124);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(257, 27);
            txtValor.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 17;
            label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(176, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(246, 27);
            txtCodigo.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 78);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 15;
            label1.Text = "Código";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(531, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(257, 27);
            txtNome.TabIndex = 30;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(176, 124);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(246, 27);
            txtDescricao.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 182);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 33;
            label6.Text = "Unidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 186);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 32;
            label7.Text = "Fornecedor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 34;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(531, 179);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(257, 28);
            comboBox2.TabIndex = 35;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 560);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(dg);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg;
        private Label label5;
        private TextBox txtBuscar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private Label label3;
        private TextBox txtValor;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}