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
    public partial class frmCadastrarUsuario : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastrarUsuario()
        {
            InitializeComponent();
            desativerCampos();
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void desativerCampos()
        {
            txtUsuario.Enabled = false; 
            txtSenha.Enabled = false;   
            txtValidarSenha.Enabled = false;    
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;   
            btnExcluir.Enabled = false; 
            btnLimpar.Enabled = false;  
            
        }

        public void ativarCampos()
        {
            btnNovo.Enabled = false;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidarSenha.Enabled = true;
            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            txtUsuario.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ativarCampos();
        }

        public int cadastrarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuario(usuario, senha) values(@usuario, @senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp; 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals("") || txtValidarSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores.",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1
                   );
            }
            else
            {
                if (txtSenha.Text.Length < 12 || txtValidarSenha.Text.Length < 12)
                {
                    MessageBox.Show("A senha tem que ser igual a 12 caracteres",
                       "Mensagem do sistema",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error,
                      MessageBoxDefaultButton.Button1
                      );
                }
                else
                {
                    if (txtSenha.Equals(txtValidarSenha.Text))
                    {

                        if (cadastrarUsuario(usuario, senha) == 1)
                        {
                            MessageBox.Show("Cadastrado com sucesso.",
                                         "Mensagem do sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                        MessageBoxDefaultButton.Button1
                                        );
                            desativerCampos();
                            limparCampos();
                        }
                        else
                        {
                                MessageBox.Show("Erro ao cadastrar!",
                           "Mensagem do sistema",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1
                      );
                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha não é igual!",
                       "Mensagem do sistema",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error,
                      MessageBoxDefaultButton.Button1
                      );
                    }
                }
            }
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtSenha.Clear();   
            txtUsuario.Clear();
            txtValidarSenha.Clear();    
        }


        private void txtValidarSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtValidarSenha.Text.Equals(txtSenha.Text))
            {
                btnChecked.Visible = true;
                btnFalseChecked.Visible = false;
            }
            else
            {
                btnChecked.Visible = false;
                btnFalseChecked.Visible = true;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abr = new frmMenu();
            abr.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        
    }
}
