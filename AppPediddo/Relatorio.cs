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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                MySqlConnection con = conexao.Conectar();

                string sql = "SELECT " +
                    "Clientes.nome, " +
                    "Clientes.cpf, " +
                    "Itens.nome_produto, " +
                    "Compras.quantidade " +
                    "From Compras " +
                    "INNER JOIN Clientes ON Compras.id_cliente = Clientes.id_cliente " +
                    "INNER JOIN Itens ON Compras.id_item = Itens.id_item ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
