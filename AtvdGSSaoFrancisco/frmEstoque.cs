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

                
                
            }
            Conexao.fecharConexao();
        }

        
    }
}
