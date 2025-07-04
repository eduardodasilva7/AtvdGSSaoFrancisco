﻿using MySql.Data.MySqlClient;
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
    public partial class frmPesquisarVoluntarios : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void frmPesquisarVoluntarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void buscarPorCodigo(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbvoluntarios WHERE codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }

        public void buscarPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbvoluntarios WHERE nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();


            ltbPesquisar.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        public void desabilitarCampos()
        {
            txtDescricao.Enabled = false;
            ltbPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            ltbPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;

        }

        public void limparCampos()
        {
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            
                habilitarCampos();
                
            
            
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
           
                habilitarCampos();

            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                buscarPorCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if(rdbNome.Checked)
            {
                buscarPorNome(txtDescricao.Text);
            }   
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmVoluntarios abrir = new frmVoluntarios(ltbPesquisar.Text);
            abrir.Show();
            this.Hide();
        }
    }
}
