using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppPediddo
{
    public partial class CadastroItem : Form
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sql = "INSERT INTO Itens (nome_produto, preco_unitario) " +
               "VALUES (@nome, @preco)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToInt32(txtPrecoProduto.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            Pedidos telaPedido = new Pedidos();
            telaPedido.Show();
            this.Hide();
        }
    }
}
