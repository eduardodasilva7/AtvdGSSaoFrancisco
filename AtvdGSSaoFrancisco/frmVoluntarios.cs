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
            cbbAtribuicoes.Text = "";
            cbbEstado.Text = "";
            ckbAtivo.Checked = false;
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
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
            cbbAtribuicoes.Enabled = false;
            cbbEstado.Enabled = false;
            ckbAtivo.Enabled = false;
            dtpData.Enabled = false;
            dtpHora.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnLimparImagem.Enabled = false;
            btnInserir.Enabled = false;

            btnNovo.Enabled = true;
            btnVoltar.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        public void habilitarCampos()
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
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            ckbAtivo.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnLimparImagem.Enabled = true;
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
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            ckbAtivo.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnLimparImagem.Enabled = true;
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

        public int cadastrarVoluntario(string nome, string email, string telCel, string endereco, string numero, string cep, string complemento, string bairro, string cidade, string estado, int codFunc, DateTime data, DateTime hora, int status, int codFotos)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,complemento,bairro,cidade,estado,codFunc,data,hora,status,codFotos)" +
                "values(@nome,@email,@telCel,@endereco,@numero,@cep,@complemento,@bairro,@cidade,@estado,@codFunc,@data,@hora,@status,@codFotos);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
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
            comm.Parameters.Add("@codFotos", MySqlDbType.Int32).Value = codFotos;


            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return resp;
        }

        string enderecoImagem;
        public void cadastrarFoto()
        {
            byte[] imagem = null;
            FileStream fs = new FileStream(enderecoImagem, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem = br.ReadBytes((int)fs.Length);


            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbfotos(imagem, enderecoImagem) VALUES (@imagem, @enderecoImagem);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@imagem", MySqlDbType.LongBlob).Value = imagem;
            comm.Parameters.Add().Value = ;
            
            comm.Connection = Conexao
        }

        /*
         
         private void btnSalvarFotos_Click(object sender, EventArgs e)
        {
            if (pctFotos.Image != null)
            {


                byte[] imagem_byte = null;

                FileStream fs = new FileStream(this.txtBuscaFotos.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);

                imagem_byte = br.ReadBytes((int)fs.Length);

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbfotos(nome,campo_imagem)values(@nome,@campo_imagem);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@campo_imagem", MySqlDbType.LongBlob).Value = imagem_byte;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;

                comm.Connection = Conexao.obterConexao();

                int resp = comm.ExecuteNonQuery();

                MessageBox.Show("Foto salva no banco de dados!!! " + resp);
                desabilitarCampos();
                limparCamposSalvar();
                btnInserirFotos.Enabled = true;

                Conexao.fecharConexao();
            }
            else
            {
                MessageBox.Show("Favor inserrir um texto ou uma imagem",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

        }
         */

    }
}
