namespace AtvdGSSaoFrancisco
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastraUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(12, 12);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(142, 219);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProduto.Image")));
            this.btnCadastroProduto.Location = new System.Drawing.Point(184, 12);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(142, 219);
            this.btnCadastroProduto.TabIndex = 1;
            this.btnCadastroProduto.Text = "Cadastro de Produtos";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(638, 490);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(134, 59);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastraUsuario.Image")));
            this.btnCadastraUsuario.Location = new System.Drawing.Point(364, 12);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(142, 219);
            this.btnCadastraUsuario.TabIndex = 14;
            this.btnCadastraUsuario.Text = "Cadastro de Usuário";
            this.btnCadastraUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastraUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastraUsuario.UseVisualStyleBackColor = true;
            this.btnCadastraUsuario.Click += new System.EventHandler(this.btnCadastraUsuario_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCadastraUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSF - Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastraUsuario;
    }
}