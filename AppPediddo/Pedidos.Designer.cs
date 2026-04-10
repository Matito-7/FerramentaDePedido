namespace AppPediddo
{
    partial class Pedidos
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
            cbClientes = new ComboBox();
            cbItens = new ComboBox();
            btnSalvarPedidos = new Button();
            btnRelatorio = new Button();
            numQuantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(53, 49);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(121, 23);
            cbClientes.TabIndex = 0;
            // 
            // cbItens
            // 
            cbItens.FormattingEnabled = true;
            cbItens.Location = new Point(53, 98);
            cbItens.Name = "cbItens";
            cbItens.Size = new Size(121, 23);
            cbItens.TabIndex = 0;
            // 
            // btnSalvarPedidos
            // 
            btnSalvarPedidos.Location = new Point(53, 162);
            btnSalvarPedidos.Name = "btnSalvarPedidos";
            btnSalvarPedidos.Size = new Size(75, 23);
            btnSalvarPedidos.TabIndex = 2;
            btnSalvarPedidos.Text = "Salvar";
            btnSalvarPedidos.UseVisualStyleBackColor = true;
            btnSalvarPedidos.Click += btnSalvarPedidos_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(200, 162);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(75, 23);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(218, 99);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(70, 23);
            numQuantidade.TabIndex = 3;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 265);
            Controls.Add(numQuantidade);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSalvarPedidos);
            Controls.Add(cbItens);
            Controls.Add(cbClientes);
            Name = "Pedidos";
            Text = "Pedidos";
            Load += Pedidos_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbClientes;
        private ComboBox cbItens;
        private Button btnSalvarPedidos;
        private Button btnRelatorio;
        private NumericUpDown numQuantidade;
    }
}