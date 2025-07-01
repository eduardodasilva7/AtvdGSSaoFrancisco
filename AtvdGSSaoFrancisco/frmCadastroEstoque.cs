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
using GenCode128;
using System.IO;

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
            desabilitarCampos();
        }

        public frmCadastroEstoque(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
            carregarProduto(txtNome.Text);

            habilitarCamposEstoque();
        }

        private void frmCadastroEstoque_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void desabilitarCampos()
        {
            dtpDataEntrada.Enabled = false;
            txtNome.Enabled = false;
            cbbCategoria.Enabled = false;
            txtPeso.Enabled = false;
            dtpValidade.Enabled = false;
            txtQuantidade.Enabled = false;
            cbbLocalizacao.Enabled = false;
            txtCodigoBarras.Enabled = false;
            txtLote.Enabled = false;
            pctCodigoBarras.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;

            btnNovo.Enabled = true;
            btnEstoque.Enabled = true;
            btnVoltar.Enabled = true;
            btnNovo.Focus();
        }

        public void habilitarCampos()
        {
            dtpDataEntrada.Enabled = true;
            txtNome.Enabled = true;
            cbbCategoria.Enabled = true;
            txtPeso.Enabled = true;
            dtpValidade.Enabled = true;
            txtQuantidade.Enabled = true;
            cbbLocalizacao.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtLote.Enabled = true;
            pctCodigoBarras.Enabled = true;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
            btnVoltar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnEstoque.Enabled = false;
            txtNome.Focus();
        }
        public void habilitarCamposEstoque()
        {
            dtpDataEntrada.Enabled = true;
            mktDataSaida.Enabled = true;
            txtNome.Enabled = true;
            cbbCategoria.Enabled = true;
            txtPeso.Enabled = true;
            dtpValidade.Enabled = true;
            txtQuantidade.Enabled = true;
            cbbLocalizacao.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtLote.Enabled = true;
            pctCodigoBarras.Enabled = true;
            btnCadastrar.Enabled = true;
            btnVoltar.Enabled = true;
            btnAlterar.Enabled = true;
            btnEstoque.Enabled = true;

            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        public int cadastrarProduto(string nome, string peso, DateTime validade, DateTime dataEntrada, string dataSaida, string categoriaProd, string quantidadeProd, string localizacaoProd, string codigoBarras, string lote)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbEstoque(nomeProd, peso, quantidadeProd, validade, dataEntrada, dataSaida, categoriaProd, localizacaoProd, codigoBarras, lote) " +
                "values(@nomeProd, @peso, @quantidadeProd, @validade, @dataEntrada, @dataSaida, @categoriaProd, @localizacaoProd, @codigoBarras, @lote);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 30).Value = nome;
            comm.Parameters.Add("@peso", MySqlDbType.VarChar, 5).Value = peso;
            comm.Parameters.Add("@validade", MySqlDbType.DateTime, 10).Value = validade;
            comm.Parameters.Add("@quantidadeProd", MySqlDbType.VarChar, 4).Value = quantidadeProd;
            comm.Parameters.Add("@dataEntrada", MySqlDbType.DateTime, 100).Value = dataEntrada;
            comm.Parameters.Add("@dataSaida", MySqlDbType.VarChar, 10).Value = dataSaida;
            comm.Parameters.Add("@categoriaProd", MySqlDbType.VarChar, 30).Value = categoriaProd;
            comm.Parameters.Add("@localizacaoProd", MySqlDbType.VarChar, 30).Value = localizacaoProd;
            comm.Parameters.Add("@codigoBarras", MySqlDbType.VarChar, 15).Value = codigoBarras;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar, 10).Value = lote;
            
            
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(cadastrarProduto(txtNome.Text, txtPeso.Text, dtpValidade.Value, dtpDataEntrada.Value, mktDataSaida.Text, cbbCategoria.SelectedItem.ToString(), txtQuantidade.Text, cbbLocalizacao.SelectedItem.ToString(), txtCodigoBarras.Text, txtLote.Text ) == 1)
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
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque abrir = new frmEstoque();
            abrir.Show();
            this.Hide();
        }

        public void carregarProduto(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbestoque WHERE nomeProd = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
                txtNome.Text = DR.GetString(1);
                txtPeso.Text = DR.GetString(2);
                txtQuantidade.Text = DR.GetString(3);
                dtpValidade.Value = DR.GetDateTime(4);
                dtpDataEntrada.Value = DR.GetDateTime(5);
                mktDataSaida.Text = DR.GetString(6);
                cbbCategoria.Text = DR.GetString(7);
                cbbLocalizacao.Text = DR.GetString(8);
                txtCodigoBarras.Text = DR.GetString(9);
                txtLote.Text = DR.GetString(10);

                

            }
            


            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int codProd = Convert.ToInt32(txtCodigo.Text);
            if (atulizarDados(codProd, txtNome.Text, txtPeso.Text, dtpValidade.Value, dtpDataEntrada.Value, mktDataSaida.Text, cbbCategoria.SelectedItem.ToString(), txtQuantidade.Text, cbbLocalizacao.SelectedItem.ToString(), txtCodigoBarras.Text, txtLote.Text) == 1)
            {
                MessageBox.Show("Produto atualizado com sucesso!",
                    "Menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        public int atulizarDados(int codigo, string nome, string peso, DateTime validade, DateTime dataEntrada, string dataSaida, string categoriaProd, string quantidadeProd, string localizacaoProd, string codigoBarras, string lote)
        {
          
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbEstoque set nomeProd = @nomeProd, peso = @peso, quantidadeProd = @quantidadeProd, validade = @validade, dataEntrada = @dataEntrada, " +
                "dataSaida = @dataSaida, categoriaProd = @categoriaProd, localizacaoProd = @localizacaoProd codigoBarras = @codigoBarras, lote = @lote where codProduto = @codigo;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 30).Value = nome;
            comm.Parameters.Add("@peso", MySqlDbType.VarChar, 5).Value = peso;
            comm.Parameters.Add("@validade", MySqlDbType.DateTime, 10).Value = validade;
            comm.Parameters.Add("@quantidadeProd", MySqlDbType.VarChar, 4).Value = quantidadeProd;
            comm.Parameters.Add("@dataEntrada", MySqlDbType.DateTime, 100).Value = dataEntrada;
            comm.Parameters.Add("@dataSaida", MySqlDbType.VarChar, 10).Value = dataSaida;
            comm.Parameters.Add("@categoriaProd", MySqlDbType.VarChar, 30).Value = categoriaProd;
            comm.Parameters.Add("@localizacaoProd", MySqlDbType.VarChar, 30).Value = localizacaoProd;
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;
            comm.Parameters.Add("@codigoBarras", MySqlDbType.VarChar, 15).Value = codigoBarras;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar, 10).Value = lote;
            

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Image imgCodigoBarras = Code128Rendering.MakeBarcodeImage(txtCodigoBarras.Text, 2, true);
                pctCodigoBarras.Image = imgCodigoBarras;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
    }
}
