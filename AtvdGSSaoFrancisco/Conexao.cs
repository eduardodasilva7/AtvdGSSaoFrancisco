using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AtvdGSSaoFrancisco
{
    public class Conexao
    {
        private static string confString = "Server=localhost;Port=3306;Database=dbatvgfs;Uid=root;Pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao() 
        {
            conn = new MySqlConnection(confString);
            try
            {
                conn.Open();
            }catch (MySqlException)
            {
                return conn = null;
            }
            return conn;


            
        }

        public static void fecharConexao()
        {
            if(conn != null)
            {
                conn.Clone();
            }
        } 
    }
}
