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
        }

        private void frmCadastroEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public int cadastrarProduto(string nome, string peso, string validade, DateTime dataEntrada, string categoriaProd, string localizacaoProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbEstoque(nomeProd, peso, validade, dataEntrada,categoriaProd, localizacaoProd) " +
                "values(@nomeProd, @peso, @validade, @dataEntrada, @categoriaProd, @localizacaoProd);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 30).Value = nome;
            comm.Parameters.Add("@peso", MySqlDbType.VarChar, 5).Value = peso;
            comm.Parameters.Add("@validade", MySqlDbType.VarChar, 10).Value = validade;
            comm.Parameters.Add("@dataEntrada", MySqlDbType.Date, 100).Value = dataEntrada;
            comm.Parameters.Add("@categoriaProd", MySqlDbType.VarChar, 30).Value = categoriaProd;
            comm.Parameters.Add("@localizacaoProd", MySqlDbType.VarChar, 30).Value = localizacaoProd;                                                                                                                            
            
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarProduto(txtNome.Text, txtPeso.Text, mktValidade.Text, dtpDataEntrada.Value, cbbCategoria.SelectedItem.ToString(), cbbLocalizacao.SelectedItem.ToString());
        }
    }
}
