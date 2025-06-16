using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvdGSSaoFrancisco
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (acessarUsuario(txtLogin.Text, txtSenha.Text)) {
                frmMenu abrir = new frmMenu();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        public void limparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtLogin.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool resp = false;
        public bool acessarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usuario, senha from tbUsuario where usuario=@usuario and senha=@senha;";
            comm.CommandType = CommandType.Text;  
            
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            try{
                DR = comm.ExecuteReader();
                resp = DR.HasRows;

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Banco de dados não conectado",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            return resp;
        }
    }
}
