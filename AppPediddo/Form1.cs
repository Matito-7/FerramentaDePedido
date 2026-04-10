using MySql.Data.MySqlClient;
using System.Data;
namespace AppPediddo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "Insert into Clientes (nome, cpf) " +
                    "Values (@nome, @cpf)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtcpf.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso");

                string sqlMostrar = "SELECT * FROM Clientes";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvClientes.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            CadastroItem telaitem = new CadastroItem();
            telaitem.Show();
            this.Hide();
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }
    }
}
