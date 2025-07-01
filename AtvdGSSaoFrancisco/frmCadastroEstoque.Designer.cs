namespace AtvdGSSaoFrancisco
{
    partial class frmCadastroEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEstoque));
            this.gpbCadEstoque = new System.Windows.Forms.GroupBox();
            this.lblImgCodigoBarras = new System.Windows.Forms.Label();
            this.pctCodigoBarras = new System.Windows.Forms.PictureBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.mktDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.cbbLocalizacao = new System.Windows.Forms.ComboBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ofdCarregarProduto = new System.Windows.Forms.OpenFileDialog();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbCadEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadEstoque
            // 
            this.gpbCadEstoque.Controls.Add(this.lblImgCodigoBarras);
            this.gpbCadEstoque.Controls.Add(this.pctCodigoBarras);
            this.gpbCadEstoque.Controls.Add(this.lblCodigoBarras);
            this.gpbCadEstoque.Controls.Add(this.txtLote);
            this.gpbCadEstoque.Controls.Add(this.lblLote);
            this.gpbCadEstoque.Controls.Add(this.txtCodigoBarras);
            this.gpbCadEstoque.Controls.Add(this.dtpValidade);
            this.gpbCadEstoque.Controls.Add(this.mktDataSaida);
            this.gpbCadEstoque.Controls.Add(this.lblDataSaida);
            this.gpbCadEstoque.Controls.Add(this.dtpDataEntrada);
            this.gpbCadEstoque.Controls.Add(this.cbbLocalizacao);
            this.gpbCadEstoque.Controls.Add(this.lblLocalizacao);
            this.gpbCadEstoque.Controls.Add(this.cbbCategoria);
            this.gpbCadEstoque.Controls.Add(this.txtQuantidade);
            this.gpbCadEstoque.Controls.Add(this.txtPeso);
            this.gpbCadEstoque.Controls.Add(this.txtNome);
            this.gpbCadEstoque.Controls.Add(this.txtCodigo);
            this.gpbCadEstoque.Controls.Add(this.lblCodigo);
            this.gpbCadEstoque.Controls.Add(this.lblData);
            this.gpbCadEstoque.Controls.Add(this.lblCategoria);
            this.gpbCadEstoque.Controls.Add(this.lblValidade);
            this.gpbCadEstoque.Controls.Add(this.lblQuantidade);
            this.gpbCadEstoque.Controls.Add(this.lblPeso);
            this.gpbCadEstoque.Controls.Add(this.lblNome);
            this.gpbCadEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadEstoque.Location = new System.Drawing.Point(12, 12);
            this.gpbCadEstoque.Name = "gpbCadEstoque";
            this.gpbCadEstoque.Size = new System.Drawing.Size(760, 453);
            this.gpbCadEstoque.TabIndex = 0;
            this.gpbCadEstoque.TabStop = false;
            this.gpbCadEstoque.Text = "Cadastro de Produtos";
            // 
            // lblImgCodigoBarras
            // 
            this.lblImgCodigoBarras.AutoSize = true;
            this.lblImgCodigoBarras.Location = new System.Drawing.Point(179, 316);
            this.lblImgCodigoBarras.Name = "lblImgCodigoBarras";
            this.lblImgCodigoBarras.Size = new System.Drawing.Size(225, 24);
            this.lblImgCodigoBarras.TabIndex = 50;
            this.lblImgCodigoBarras.Text = "Imagem código de barras";
            // 
            // pctCodigoBarras
            // 
            this.pctCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctCodigoBarras.Location = new System.Drawing.Point(171, 343);
            this.pctCodigoBarras.Name = "pctCodigoBarras";
            this.pctCodigoBarras.Size = new System.Drawing.Size(383, 85);
            this.pctCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctCodigoBarras.TabIndex = 49;
            this.pctCodigoBarras.TabStop = false;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(106, 257);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(155, 24);
            this.lblCodigoBarras.TabIndex = 47;
            this.lblCodigoBarras.Text = "Código de barras";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(491, 280);
            this.txtLote.MaxLength = 5;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(102, 29);
            this.txtLote.TabIndex = 9;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(491, 257);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(46, 24);
            this.lblLote.TabIndex = 46;
            this.lblLote.Text = "Lote";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(110, 284);
            this.txtCodigoBarras.MaxLength = 13;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(261, 29);
            this.txtCodigoBarras.TabIndex = 8;
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(110, 225);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(128, 29);
            this.dtpValidade.TabIndex = 5;
            // 
            // mktDataSaida
            // 
            this.mktDataSaida.Enabled = false;
            this.mktDataSaida.Location = new System.Drawing.Point(488, 61);
            this.mktDataSaida.Mask = "00/00/0000";
            this.mktDataSaida.Name = "mktDataSaida";
            this.mktDataSaida.Size = new System.Drawing.Size(130, 29);
            this.mktDataSaida.TabIndex = 17;
            this.mktDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(484, 34);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(126, 24);
            this.lblDataSaida.TabIndex = 16;
            this.lblDataSaida.Text = "Data de Saida";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(299, 61);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(128, 29);
            this.dtpDataEntrada.TabIndex = 1;
            // 
            // cbbLocalizacao
            // 
            this.cbbLocalizacao.FormattingEnabled = true;
            this.cbbLocalizacao.ItemHeight = 24;
            this.cbbLocalizacao.Items.AddRange(new object[] {
            "Rotary",
            "Avulso",
            "Drive Thru"});
            this.cbbLocalizacao.Location = new System.Drawing.Point(488, 222);
            this.cbbLocalizacao.Name = "cbbLocalizacao";
            this.cbbLocalizacao.Size = new System.Drawing.Size(130, 32);
            this.cbbLocalizacao.TabIndex = 7;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(484, 198);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(109, 24);
            this.lblLocalizacao.TabIndex = 14;
            this.lblLocalizacao.Text = "Localização";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.ItemHeight = 24;
            this.cbbCategoria.Items.AddRange(new object[] {
            "Necessário ",
            "Diverso "});
            this.cbbCategoria.Location = new System.Drawing.Point(299, 134);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(130, 32);
            this.cbbCategoria.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(299, 225);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(130, 29);
            this.txtQuantidade.TabIndex = 6;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(488, 137);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(130, 29);
            this.txtPeso.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 29);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(110, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(106, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(295, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(144, 24);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data de Entrada";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(295, 110);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(106, 198);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(84, 24);
            this.lblValidade.TabIndex = 3;
            this.lblValidade.Text = "Validade";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(295, 198);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(108, 24);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(484, 110);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 24);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(106, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(132, 469);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 59);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(262, 469);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 59);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(391, 470);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 59);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(520, 470);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(123, 59);
            this.btnEstoque.TabIndex = 14;
            this.btnEstoque.Text = "&Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(649, 470);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 59);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ofdCarregarProduto
            // 
            this.ofdCarregarProduto.FileName = "openFileDialog1";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(12, 471);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 59);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadastroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbCadEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSF - Cadastro Estoque";
            this.Load += new System.EventHandler(this.frmCadastroEstoque_Load);
            this.gpbCadEstoque.ResumeLayout(false);
            this.gpbCadEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCodigoBarras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadEstoque;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.ComboBox cbbLocalizacao;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.MaskedTextBox mktDataSaida;
        private System.Windows.Forms.Label lblImgCodigoBarras;
        private System.Windows.Forms.PictureBox pctCodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.OpenFileDialog ofdCarregarProduto;
        private System.Windows.Forms.Button btnNovo;
    }
}