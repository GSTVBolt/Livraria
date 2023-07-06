namespace Livraria
{
    partial class frmCategoria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblCodCateg = new System.Windows.Forms.Label();
            this.lblCodigoCateg = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvCateg = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaCateg = new System.Windows.Forms.TextBox();
            this.cbxCateg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodLiv = new System.Windows.Forms.Label();
            this.lblCodLivro = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBusca = new System.Windows.Forms.TabPage();
            this.tabBusca2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscaTit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBusca.SuspendLayout();
            this.tabBusca2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCategoria.Location = new System.Drawing.Point(312, 32);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(220, 51);
            this.lblCategoria.TabIndex = 72;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlterar.Location = new System.Drawing.Point(682, 231);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 43);
            this.btnAlterar.TabIndex = 218;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblCodCateg
            // 
            this.lblCodCateg.AutoSize = true;
            this.lblCodCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCateg.ForeColor = System.Drawing.Color.Red;
            this.lblCodCateg.Location = new System.Drawing.Point(159, 79);
            this.lblCodCateg.Name = "lblCodCateg";
            this.lblCodCateg.Size = new System.Drawing.Size(0, 24);
            this.lblCodCateg.TabIndex = 194;
            this.lblCodCateg.Visible = false;
            // 
            // lblCodigoCateg
            // 
            this.lblCodigoCateg.AutoSize = true;
            this.lblCodigoCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCateg.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoCateg.Location = new System.Drawing.Point(74, 79);
            this.lblCodigoCateg.Name = "lblCodigoCateg";
            this.lblCodigoCateg.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoCateg.TabIndex = 193;
            this.lblCodigoCateg.Text = "Código:";
            this.lblCodigoCateg.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.Location = new System.Drawing.Point(682, 281);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 43);
            this.btnExcluir.TabIndex = 219;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvCateg
            // 
            this.dgvCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCateg.Location = new System.Drawing.Point(57, 428);
            this.dgvCateg.MultiSelect = false;
            this.dgvCateg.Name = "dgvCateg";
            this.dgvCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCateg.Size = new System.Drawing.Size(604, 114);
            this.dgvCateg.TabIndex = 213;
            this.dgvCateg.DoubleClick += new System.EventHandler(this.dgvCateg_DoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(682, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 43);
            this.btnSalvar.TabIndex = 203;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Location = new System.Drawing.Point(682, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 43);
            this.btnCancelar.TabIndex = 202;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Location = new System.Drawing.Point(682, 131);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 43);
            this.btnNovo.TabIndex = 201;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaCateg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(28, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 63);
            this.groupBox1.TabIndex = 212;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Categoria";
            // 
            // txtBuscaCateg
            // 
            this.txtBuscaCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCateg.Location = new System.Drawing.Point(64, 28);
            this.txtBuscaCateg.MaxLength = 60;
            this.txtBuscaCateg.Name = "txtBuscaCateg";
            this.txtBuscaCateg.Size = new System.Drawing.Size(401, 29);
            this.txtBuscaCateg.TabIndex = 12;
            this.txtBuscaCateg.TextChanged += new System.EventHandler(this.txtBuscaCateg_TextChanged);
            // 
            // cbxCateg
            // 
            this.cbxCateg.DisplayMember = "tbl_Categoria.nm_Categoria";
            this.cbxCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCateg.FormattingEnabled = true;
            this.cbxCateg.Location = new System.Drawing.Point(168, 189);
            this.cbxCateg.Name = "cbxCateg";
            this.cbxCateg.Size = new System.Drawing.Size(263, 32);
            this.cbxCateg.TabIndex = 222;
            this.cbxCateg.TabStop = false;
            this.cbxCateg.ValueMember = "tbl_Categoria.cd_Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(57, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 221;
            this.label1.Text = "Categoria:";
            // 
            // txtCateg
            // 
            this.txtCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateg.Location = new System.Drawing.Point(168, 189);
            this.txtCateg.MaxLength = 60;
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(263, 29);
            this.txtCateg.TabIndex = 13;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(168, 150);
            this.txtTitulo.MaxLength = 60;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(263, 29);
            this.txtTitulo.TabIndex = 224;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitulo.Location = new System.Drawing.Point(91, 150);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 24);
            this.lblTitulo.TabIndex = 223;
            this.lblTitulo.Text = "Título:";
            // 
            // lblCodLiv
            // 
            this.lblCodLiv.AutoSize = true;
            this.lblCodLiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodLiv.ForeColor = System.Drawing.Color.Red;
            this.lblCodLiv.Location = new System.Drawing.Point(573, 150);
            this.lblCodLiv.Name = "lblCodLiv";
            this.lblCodLiv.Size = new System.Drawing.Size(0, 24);
            this.lblCodLiv.TabIndex = 226;
            this.lblCodLiv.Visible = false;
            // 
            // lblCodLivro
            // 
            this.lblCodLivro.AutoSize = true;
            this.lblCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodLivro.ForeColor = System.Drawing.Color.Red;
            this.lblCodLivro.Location = new System.Drawing.Point(474, 150);
            this.lblCodLivro.Name = "lblCodLivro";
            this.lblCodLivro.Size = new System.Drawing.Size(95, 24);
            this.lblCodLivro.TabIndex = 225;
            this.lblCodLivro.Text = "Cod Livro:";
            this.lblCodLivro.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBusca);
            this.tabControl1.Controls.Add(this.tabBusca2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(57, 322);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 100);
            this.tabControl1.TabIndex = 227;
            // 
            // tabBusca
            // 
            this.tabBusca.BackColor = System.Drawing.Color.Transparent;
            this.tabBusca.Controls.Add(this.groupBox1);
            this.tabBusca.Location = new System.Drawing.Point(4, 27);
            this.tabBusca.Name = "tabBusca";
            this.tabBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusca.Size = new System.Drawing.Size(596, 69);
            this.tabBusca.TabIndex = 0;
            this.tabBusca.Text = "Categoria";
            // 
            // tabBusca2
            // 
            this.tabBusca2.BackColor = System.Drawing.Color.Transparent;
            this.tabBusca2.Controls.Add(this.groupBox2);
            this.tabBusca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBusca2.Location = new System.Drawing.Point(4, 27);
            this.tabBusca2.Name = "tabBusca2";
            this.tabBusca2.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusca2.Size = new System.Drawing.Size(596, 69);
            this.tabBusca2.TabIndex = 1;
            this.tabBusca2.Text = "Título";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscaTit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(27, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 63);
            this.groupBox2.TabIndex = 213;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por Título";
            // 
            // txtBuscaTit
            // 
            this.txtBuscaTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaTit.Location = new System.Drawing.Point(64, 28);
            this.txtBuscaTit.MaxLength = 60;
            this.txtBuscaTit.Name = "txtBuscaTit";
            this.txtBuscaTit.Size = new System.Drawing.Size(401, 29);
            this.txtBuscaTit.TabIndex = 12;
            this.txtBuscaTit.TextChanged += new System.EventHandler(this.txtBuscaTit_TextChanged);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblCodLiv);
            this.Controls.Add(this.lblCodLivro);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.cbxCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblCodCateg);
            this.Controls.Add(this.lblCodigoCateg);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvCateg);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmCategoria";
            this.Size = new System.Drawing.Size(848, 620);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBusca.ResumeLayout(false);
            this.tabBusca2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblCodCateg;
        private System.Windows.Forms.Label lblCodigoCateg;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvCateg;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaCateg;
        private System.Windows.Forms.ComboBox cbxCateg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCateg;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodLiv;
        private System.Windows.Forms.Label lblCodLivro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBusca;
        private System.Windows.Forms.TabPage tabBusca2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscaTit;
    }
}
