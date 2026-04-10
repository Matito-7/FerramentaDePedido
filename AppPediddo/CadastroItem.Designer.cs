namespace AppPediddo
{
    partial class CadastroItem
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
            txtNomeProduto = new TextBox();
            txtPrecoProduto = new TextBox();
            btnSalvarProduto = new Button();
            btnFazerPedido = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(39, 68);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(157, 68);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(100, 23);
            txtPrecoProduto.TabIndex = 0;
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(39, 136);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(75, 23);
            btnSalvarProduto.TabIndex = 1;
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            btnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.Location = new Point(39, 180);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(105, 23);
            btnFazerPedido.TabIndex = 1;
            btnFazerPedido.Text = "Fazer Pedido";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 45);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço";
            // 
            // CadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 231);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnSalvarProduto);
            Controls.Add(txtPrecoProduto);
            Controls.Add(txtNomeProduto);
            Name = "CadastroItem";
            Text = "CadastroItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProduto;
        private TextBox txtPrecoProduto;
        private Button btnSalvarProduto;
        private Button btnFazerPedido;
        private Label label1;
        private Label label2;
    }
}