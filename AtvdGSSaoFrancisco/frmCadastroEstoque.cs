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

namespace AtvdGSSaoFrancisco
{
    public partial class frmCadastroEstoque : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastroEstoque()
        {
            InitializeComponent();
            limparCampos();
        }

        private void frmCadastroEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public int cadastrarProduto(string nome, string peso, DateTime validade, DateTime dataEntrada, string dataSaida, string categoriaProd, string quantidadeProd, string localizacaoProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbEstoque(nomeProd, peso, quantidadeProd, validade, dataEntrada, dataSaida, categoriaProd, localizacaoProd) " +
                "values(@nomeProd, @peso, @quantidadeProd, @validade, @dataEntrada, @dataSaida, @categoriaProd, @localizacaoProd);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 30).Value = nome;
            comm.Parameters.Add("@peso", MySqlDbType.VarChar, 5).Value = peso;
            comm.Parameters.Add("@validade", MySqlDbType.Date, 10).Value = validade;
            comm.Parameters.Add("@quantidadeProd", MySqlDbType.VarChar, 4).Value = quantidadeProd;
            comm.Parameters.Add("@dataEntrada", MySqlDbType.Date, 100).Value = dataEntrada;
            comm.Parameters.Add("@dataSaida", MySqlDbType.VarChar, 10).Value = dataSaida;
            comm.Parameters.Add("@categoriaProd", MySqlDbType.VarChar, 30).Value = categoriaProd;
            comm.Parameters.Add("@localizacaoProd", MySqlDbType.VarChar, 30).Value = localizacaoProd;                                                                                                                            
            
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(cadastrarProduto(txtNome.Text, txtPeso.Text, dtpValidade.Value, dtpDataEntrada.Value, mktDataSaida.Text, cbbCategoria.SelectedItem.ToString(), txtQuantidade.Text, cbbLocalizacao.SelectedItem.ToString()) == 1)
            {
                MessageBox.Show("Produto Cadastrado com sucesso!",
                    "Menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                if(txtNome.Text.Equals("") || txtPeso.Text.Equals("") || cbbCategoria.SelectedIndex == -1 || dtpValidade.Text.Equals("") || mktDataSaida.Text.Equals("  /  /") || txtQuantidade.Text.Equals("") || cbbLocalizacao.SelectedIndex == -1)
                MessageBox.Show("Complete as informações!",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mktDataSaida.Clear();
            txtPeso.Clear();
            dtpValidade.Text.Equals("");
            txtQuantidade.Clear();
            cbbCategoria.SelectedIndex = -1;
            cbbLocalizacao.SelectedIndex = -1;
            mktDataSaida.Text = "00/00/0000";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque abrir = new frmEstoque();
            abrir.Show();
            this.Hide();
        }
    }
}
