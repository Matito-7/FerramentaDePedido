using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppPediddo
{
    internal class Conexao
    {
        private static string conexao = "server = localhost;" +
            "user=root;pwd=;database=hamburgueria;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(conexao);
        }
    }
}
