using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvdGSSaoFrancisco
{
    public partial class frmGerenciarFuncoes : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarFuncoes()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmGerenciarFuncoes(string nome)
        {
            InitializeComponent();
            txtFuncao.Text = nome;
            carregarFuncao(nome);
            habilitarCamposNovo();
        }

        private void frmGerenciarFuncoes_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        public int cadastrarFuncao(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO tbfuncoes(descricao) VALUES (@descricao);";
            comm.Parameters.Clear();

            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;

            comm.Connection = Conexao.obterConexao();
            int resp = comm.ExecuteNonQuery();
            Conexao.fecharConexao();
            return resp;

        }

        public int alterarFuncao(int codFunc, string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "UPDATE tbfuncoes set descricao = @descricao where codFunc = @codFunc ;";
            comm.Parameters.Clear();

            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;

            comm.Connection = Conexao.obterConexao();
            int resp = comm.ExecuteNonQuery();
            Conexao.fecharConexao();
            return resp;

        }

        public int deletarFuncao(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbfuncoes where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtFuncao.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo função.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                
            }
            else
            {
                if (cadastrarFuncao(txtFuncao.Text) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso.",
                        "Messagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCampos();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncao abrir = new frmPesquisarFuncao();
            abrir.Show();
            this.Hide();
        }

        public void carregarFuncao(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbfuncoes where descricao = @descricao;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtFuncao.Text = DR.GetString(1);

            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(alterarFuncao(Convert.ToInt32(txtCodigo.Text), txtFuncao.Text) == 1)
            {
                MessageBox.Show("Alterado com sucesso.",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCampos();

            }
            else {
                MessageBox.Show("Erro ao alterar.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (deletarFuncao(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Deletado com sucesso.",
                        "Messagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtFuncao.Clear();
        }   

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtFuncao.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
           
            btnLimpar.Enabled = false;

            btnNovo.Enabled = true;
            btnVoltar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
           
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;

            btnCadastrar.Enabled = true;
            btnVoltar.Enabled = true;
            txtFuncao.Enabled = true;
            btnLimpar.Enabled = true;
        }

        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;

            btnCadastrar.Enabled = false;
            btnVoltar.Enabled = true;
            txtFuncao.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
    }
}
