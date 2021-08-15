
namespace ExemploLogin.Views.Cadastros
{
    partial class FrmCadUsuarios
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.grbHistorico = new System.Windows.Forms.GroupBox();
            this.txtUsuarioHist = new System.Windows.Forms.TextBox();
            this.txtTipoHist = new System.Windows.Forms.TextBox();
            this.txtDataHoraHist = new System.Windows.Forms.TextBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.grbHistorico.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnVoltar);
            this.panelTop.Controls.Add(this.btnEditar);
            this.panelTop.Controls.Add(this.btnCancelar);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.btnNovo);
            this.panelTop.Controls.Add(this.btnSalvar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(584, 65);
            this.panelTop.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(497, 10);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 45);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(263, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 45);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(419, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 45);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(107, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 45);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(185, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 45);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(341, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 45);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.grbHistorico);
            this.panelFill.Controls.Add(this.grbCadastro);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 65);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(584, 236);
            this.panelFill.TabIndex = 0;
            // 
            // grbHistorico
            // 
            this.grbHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbHistorico.Controls.Add(this.txtUsuarioHist);
            this.grbHistorico.Controls.Add(this.txtTipoHist);
            this.grbHistorico.Controls.Add(this.txtDataHoraHist);
            this.grbHistorico.Controls.Add(this.btnHistorico);
            this.grbHistorico.Controls.Add(this.label8);
            this.grbHistorico.Controls.Add(this.label7);
            this.grbHistorico.Controls.Add(this.label6);
            this.grbHistorico.Location = new System.Drawing.Point(12, 158);
            this.grbHistorico.Name = "grbHistorico";
            this.grbHistorico.Size = new System.Drawing.Size(560, 70);
            this.grbHistorico.TabIndex = 1;
            this.grbHistorico.TabStop = false;
            this.grbHistorico.Text = "Histórico";
            // 
            // txtUsuarioHist
            // 
            this.txtUsuarioHist.Location = new System.Drawing.Point(124, 36);
            this.txtUsuarioHist.Name = "txtUsuarioHist";
            this.txtUsuarioHist.ReadOnly = true;
            this.txtUsuarioHist.Size = new System.Drawing.Size(175, 20);
            this.txtUsuarioHist.TabIndex = 1;
            // 
            // txtTipoHist
            // 
            this.txtTipoHist.Location = new System.Drawing.Point(305, 36);
            this.txtTipoHist.Name = "txtTipoHist";
            this.txtTipoHist.ReadOnly = true;
            this.txtTipoHist.Size = new System.Drawing.Size(150, 20);
            this.txtTipoHist.TabIndex = 2;
            // 
            // txtDataHoraHist
            // 
            this.txtDataHoraHist.Location = new System.Drawing.Point(18, 36);
            this.txtDataHoraHist.Name = "txtDataHoraHist";
            this.txtDataHoraHist.ReadOnly = true;
            this.txtDataHoraHist.Size = new System.Drawing.Size(100, 20);
            this.txtDataHoraHist.TabIndex = 0;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(470, 34);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data/Hora:";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCadastro.Controls.Add(this.cboSituacao);
            this.grbCadastro.Controls.Add(this.label5);
            this.grbCadastro.Controls.Add(this.cboCategoria);
            this.grbCadastro.Controls.Add(this.txtSenha);
            this.grbCadastro.Controls.Add(this.txtNomeUsuario);
            this.grbCadastro.Controls.Add(this.txtId);
            this.grbCadastro.Controls.Add(this.label4);
            this.grbCadastro.Controls.Add(this.label3);
            this.grbCadastro.Controls.Add(this.label2);
            this.grbCadastro.Controls.Add(this.label1);
            this.grbCadastro.Location = new System.Drawing.Point(12, 6);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(560, 146);
            this.grbCadastro.TabIndex = 0;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Dados do Cadastro";
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(174, 100);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(150, 21);
            this.cboSituacao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(18, 100);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(150, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(280, 46);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(125, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(74, 46);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 46);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // FrmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmCadUsuarios_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.grbHistorico.ResumeLayout(false);
            this.grbHistorico.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.GroupBox grbHistorico;
        private System.Windows.Forms.TextBox txtUsuarioHist;
        private System.Windows.Forms.TextBox txtTipoHist;
        private System.Windows.Forms.TextBox txtDataHoraHist;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}