
namespace ExemploLogin.Views.Cadastros
{
    partial class FrmBuscarUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioConsultaViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioConsultaViewModelBindingSource)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResultado
            // 
            this.grbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbResultado.Controls.Add(this.dataGridView);
            this.grbResultado.Location = new System.Drawing.Point(12, 90);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(660, 262);
            this.grbResultado.TabIndex = 3;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeUsuarioDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.usuarioConsultaViewModelBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(654, 243);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            this.nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
            this.nomeUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioConsultaViewModelBindingSource
            // 
            this.usuarioConsultaViewModelBindingSource.DataSource = typeof(ExemploLogin.Views.ViewModels.UsuarioConsultaViewModel);
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.cboSituacao);
            this.grbFiltros.Controls.Add(this.label5);
            this.grbFiltros.Controls.Add(this.cboCategoria);
            this.grbFiltros.Controls.Add(this.label4);
            this.grbFiltros.Controls.Add(this.txtNomeUsuario);
            this.grbFiltros.Controls.Add(this.txtId);
            this.grbFiltros.Controls.Add(this.label2);
            this.grbFiltros.Controls.Add(this.label1);
            this.grbFiltros.Location = new System.Drawing.Point(12, 9);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(660, 75);
            this.grbFiltros.TabIndex = 2;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(570, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 45);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(408, 40);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(150, 21);
            this.cboSituacao.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Situação:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(252, 40);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(150, 21);
            this.cboCategoria.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(71, 40);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtNomeUsuario.TabIndex = 1;
            this.txtNomeUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltro_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 0;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltro_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // FrmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbFiltros);
            this.KeyPreview = true;
            this.Name = "FrmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisa de Usuário";
            this.Load += new System.EventHandler(this.FrmBuscarUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscarUsuario_KeyDown);
            this.grbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioConsultaViewModelBindingSource)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioConsultaViewModelBindingSource;
    }
}