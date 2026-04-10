namespace AppPediddo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtcpf = new TextBox();
            btnSalvar = new Button();
            btnCadastrarItens = new Button();
            btnFazerPedido = new Button();
            dgvClientes = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(114, 29);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(252, 114);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(100, 23);
            txtcpf.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(46, 161);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCadastrarItens
            // 
            btnCadastrarItens.Location = new Point(12, 406);
            btnCadastrarItens.Name = "btnCadastrarItens";
            btnCadastrarItens.Size = new Size(143, 23);
            btnCadastrarItens.TabIndex = 2;
            btnCadastrarItens.Text = "Cadastrar Itens";
            btnCadastrarItens.UseVisualStyleBackColor = true;
            btnCadastrarItens.Click += btnCadastrarItens_Click;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.Location = new Point(213, 406);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(139, 23);
            btnFazerPedido.TabIndex = 2;
            btnFazerPedido.Text = "Fazer Pedidio";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 209);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(425, 191);
            dgvClientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 96);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 0;
            label3.Text = "CPF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(dgvClientes);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnCadastrarItens);
            Controls.Add(btnSalvar);
            Controls.Add(txtcpf);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtcpf;
        private Button btnSalvar;
        private Button btnCadastrarItens;
        private Button btnFazerPedido;
        private DataGridView dgvClientes;
        private Label label2;
        private Label label3;
    }
}
