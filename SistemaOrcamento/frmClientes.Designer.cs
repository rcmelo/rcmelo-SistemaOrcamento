namespace SistemaOrcamento
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            txtTelefone = new TextBox();
            dg = new DataGridView();
            label5 = new Label();
            txtBuscar = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(139, 122);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(246, 27);
            txtTelefone.TabIndex = 46;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(49, 201);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(702, 232);
            dg.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, -23);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 43;
            label5.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(558, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(193, 27);
            txtBuscar.TabIndex = 42;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(520, 474);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 41;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(410, 474);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 40;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(299, 474);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(189, 474);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 38;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 129);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 37;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 36;
            label3.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(505, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 27);
            txtEmail.TabIndex = 35;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(139, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 27);
            txtNome.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 32;
            label1.Text = "Nome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 15);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 47;
            label6.Text = "Nome";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 545);
            Controls.Add(label6);
            Controls.Add(txtTelefone);
            Controls.Add(dg);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private DataGridView dg;
        private Label label5;
        private TextBox txtBuscar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label1;
        private Label label6;
    }
}