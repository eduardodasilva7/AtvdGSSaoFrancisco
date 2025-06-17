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
    public partial class frmMenu : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque abrir = new frmEstoque();
            abrir.Show();
            this.Hide();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastroEstoque abrir = new frmCadastroEstoque();
            abrir.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }
        
        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario abrir = new frmCadastrarUsuario();
            abrir.Show();
            this.Hide();
        }
    }
}
