using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace AtvdGSSaoFrancisco
{
    public partial class frmVoluntarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmVoluntarios()
        {
            InitializeComponent();
            desabilitarCampos();
            carregarFuncoes();
        }

        public frmVoluntarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            carregarFuncoes();
            txtNome.Text = nome;
            carregaVoluntario(nome);
        }

        private void frmVoluntarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            mktCEP.Clear();
            mktCelular.Clear();
            cbbFuncao.Text = "";
            cbbEstado.Text = "";
            ckbAtivo.Checked = false;
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
            txtNome.Focus();
            ptbFoto.Image = null;
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            mktCEP.Enabled = false;
            mktCelular.Enabled = false;
            cbbFuncao.Enabled = false;
            cbbEstado.Enabled = false;
            ckbAtivo.Enabled = false;
            dtpData.Enabled = false;
            dtpHora.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnSalvar.Enabled = false;
            btnInserir.Enabled = false;

            btnNovo.Enabled = true;
            btnVoltar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mktCEP.Enabled = true;
            mktCelular.Enabled = true;
            cbbFuncao.Enabled = true;
            cbbEstado.Enabled = true;
            ckbAtivo.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnSalvar.Enabled = true;
            btnInserir.Enabled = true;

            btnNovo.Enabled = false;
            btnVoltar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        public void habilitarCamposPesquisa()
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mktCEP.Enabled = true;
            mktCelular.Enabled = true;
            cbbFuncao.Enabled = true;
            cbbEstado.Enabled = true;
            ckbAtivo.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnSalvar.Enabled = true;
            btnInserir.Enabled = true;

            btnNovo.Enabled = false;
            btnVoltar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        public void carregaVoluntario(string nome)
        {

        }

        public int cadastrarVoluntario(string nome, string email, string telCel, string endereco, string numero, string cep, string complemento, string bairro, string cidade, string estado, int codFunc, DateTime data, DateTime hora, int status, byte[] fotos)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,complemento,bairro,cidade,estado,codFunc,data,hora,status,fotos)" +
                "values(@nome,@email,@telCel,@endereco,@numero,@cep,@complemento,@bairro,@cidade,@estado,@codFunc,@data,@hora,@status,@fotos);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 50).Value = complemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 30).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;
            comm.Parameters.Add("@data", MySqlDbType.DateTime).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.DateTime).Value = hora;
            comm.Parameters.Add("@status", MySqlDbType.Int32).Value = status;
            comm.Parameters.Add("@fotos", MySqlDbType.LongBlob).Value = fotos;


            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return resp;
        }

        string enderecoImagem;
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                enderecoImagem = foto;
                ptbFoto.ImageLocation = foto;
                txtNome.Focus();
            }
        }

        public byte[] salvarFotos()
        {
            byte[] imagem_byte = null;

            FileStream fs = new FileStream(enderecoImagem,
                FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (ckbAtivo.Checked)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
            if(cadastrarVoluntario(txtNome.Text, txtEmail.Text, mktCelular.Text, txtEndereco.Text, txtNumero.Text, mktCEP.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbbEstado.Text, codFunc, dtpData.Value, dtpHora.Value, status, salvarFotos()) == 1)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios abrir = new frmPesquisarVoluntarios();
            abrir.Show();
            this.Hide();
        }

        public void carregarFuncoes()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncoes;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbFuncao.Items.Add(DR.GetString(1));
            }
            Conexao.fecharConexao();
        }

        int codFunc;

        public int buscaCodigoFuncao(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbfuncoes where descricao = @descricao;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            int codFunc = DR.GetInt32(0);
            Conexao.fecharConexao();

            return codFunc;
        }
        private void cbbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            codFunc = buscaCodigoFuncao(cbbFuncao.SelectedItem.ToString()); 
            
        }
    }
}
