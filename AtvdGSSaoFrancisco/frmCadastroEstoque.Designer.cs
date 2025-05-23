﻿namespace AtvdGSSaoFrancisco
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.mktData = new System.Windows.Forms.MaskedTextBox();
            this.mktValidade = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.cbbLocalizacao = new System.Windows.Forms.ComboBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.gpbCadEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadEstoque
            // 
            this.gpbCadEstoque.Controls.Add(this.cbbLocalizacao);
            this.gpbCadEstoque.Controls.Add(this.lblLocalizacao);
            this.gpbCadEstoque.Controls.Add(this.cbbCategoria);
            this.gpbCadEstoque.Controls.Add(this.mktValidade);
            this.gpbCadEstoque.Controls.Add(this.mktData);
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
            this.gpbCadEstoque.Size = new System.Drawing.Size(760, 414);
            this.gpbCadEstoque.TabIndex = 0;
            this.gpbCadEstoque.TabStop = false;
            this.gpbCadEstoque.Text = "Cadastro de Produtos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 157);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(577, 157);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 24);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(339, 266);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(108, 24);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(53, 266);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(84, 24);
            this.lblValidade.TabIndex = 3;
            this.lblValidade.Text = "Validade";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(339, 157);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(577, 59);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(144, 24);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data de Entrada";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(53, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(57, 86);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 184);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 29);
            this.txtNome.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(581, 184);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(130, 29);
            this.txtPeso.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(343, 293);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(130, 29);
            this.txtQuantidade.TabIndex = 6;
            // 
            // mktData
            // 
            this.mktData.Enabled = false;
            this.mktData.Location = new System.Drawing.Point(581, 86);
            this.mktData.Mask = "00/00/0000";
            this.mktData.Name = "mktData";
            this.mktData.Size = new System.Drawing.Size(130, 29);
            this.mktData.TabIndex = 12;
            this.mktData.ValidatingType = typeof(System.DateTime);
            // 
            // mktValidade
            // 
            this.mktValidade.Location = new System.Drawing.Point(57, 293);
            this.mktValidade.Mask = "00/00/0000";
            this.mktValidade.Name = "mktValidade";
            this.mktValidade.Size = new System.Drawing.Size(130, 29);
            this.mktValidade.TabIndex = 5;
            this.mktValidade.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(21, 471);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(168, 59);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(195, 471);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 59);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(350, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 59);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(491, 471);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(141, 59);
            this.btnEstoque.TabIndex = 11;
            this.btnEstoque.Text = "&Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(638, 471);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(134, 59);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.ItemHeight = 24;
            this.cbbCategoria.Location = new System.Drawing.Point(343, 181);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(130, 32);
            this.cbbCategoria.TabIndex = 3;
            // 
            // cbbLocalizacao
            // 
            this.cbbLocalizacao.FormattingEnabled = true;
            this.cbbLocalizacao.ItemHeight = 24;
            this.cbbLocalizacao.Location = new System.Drawing.Point(581, 290);
            this.cbbLocalizacao.Name = "cbbLocalizacao";
            this.cbbLocalizacao.Size = new System.Drawing.Size(130, 32);
            this.cbbLocalizacao.TabIndex = 7;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(577, 266);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(109, 24);
            this.lblLocalizacao.TabIndex = 14;
            this.lblLocalizacao.Text = "Localização";
            // 
            // frmCadastroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.gpbCadEstoque.ResumeLayout(false);
            this.gpbCadEstoque.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mktData;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mktValidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.ComboBox cbbLocalizacao;
        private System.Windows.Forms.Label lblLocalizacao;
    }
}