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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            conn.Open();

            string sql = "SELECT * FROM Clientes";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbClientes.DataSource = dt;
            cbClientes.DisplayMember = "nome";
            cbClientes.ValueMember = "id_cliente";

            string sqlItens = "SELECT * FROM itens";
            MySqlDataAdapter adp = new MySqlDataAdapter(sqlItens, conn);

            DataTable dt2 = new DataTable();
            adp.Fill(dt2);

            cbItens.DataSource = dt2;
            cbItens.DisplayMember = "nome_produto";
            cbItens.ValueMember = "id_item";
        }

        private void btnSalvarPedidos_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            int iditem = Convert.ToInt32(cbItens.SelectedValue);
            int quantidade = Convert.ToInt32(numQuantidade.Value);

            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();

                string sql = "Insert into Compras" +
                    "(id_cliente, id_item, quantidade)" +
                    "Values" +
                    "(@cliente, @item, @qtd)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cliente", idCliente);
                cmd.Parameters.AddWithValue("@item", iditem);
                cmd.Parameters.AddWithValue("@qtd", quantidade);

                MessageBox.Show("Compra salva com sucesso");

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
            this.Hide();
        }
    }
}
