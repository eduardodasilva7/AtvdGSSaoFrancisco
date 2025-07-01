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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtvdGSSaoFrancisco
{
    public partial class frmEstoque : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmEstoque()
        {

            InitializeComponent();
            carregaEstoque();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroEstoque abrir = new frmCadastroEstoque();
            abrir.Show();
            this.Hide();
        }

        public void carregaEstoque()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbestoque;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while(DR.Read())
            {
                
                
                    ltbEstoque.Items.Add(
                        DR.GetInt32(0).ToString() + "   | " +
                        DR.GetString(1) + "   | " +
                        DR.GetString(2) + "   | " +
                        DR.GetString(3) + "   | " +
                        DR.GetDateTime(4).ToString() + "   | " +
                        DR.GetDateTime(5).ToString() + "   | " +
                        DR.GetString(6) + "   | " +
                        DR.GetString(7) + "   | " +
                        DR.GetString(8)
                        );
                

                
                
            }
            Conexao.fecharConexao();
        }

        private void ltbEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string linhaSelecionada = ltbEstoque.SelectedItem.ToString();

            string[] campos = linhaSelecionada.Split('|');
            int codigo = int.Parse(campos[0].Trim());

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente apagar este produto?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (resultado == DialogResult.Yes) {
                if(apagarProduto(codigo) == 1)
                {
                    MessageBox.Show("Produto apagado com sucesso!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    ltbEstoque.Items.Remove(ltbEstoque.SelectedItem);
                }
                

            }
            else{
                MessageBox.Show("Erro ao apagar produto!",
                                    "Mensagem do sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        public int apagarProduto(int codProduto)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbestoque WHERE codProduto = @codProduto;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProduto", MySqlDbType.Int32).Value = codProduto;
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ltbEstoque.SelectedItems != null)
            {
                try
                {
                    string linha = ltbEstoque.SelectedItem.ToString();
                    string[] campos = linha.Split('|');
                    string nome = campos[1].Trim();
                    frmCadastroEstoque abrir = new frmCadastroEstoque(nome);
                    abrir.Show();
                    this.Hide();
                }
                catch(Exception) {
                    MessageBox.Show("Selecione um produto!",
                    "Menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
