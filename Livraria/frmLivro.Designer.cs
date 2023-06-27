namespace Livraria
{
    partial class frmLivro
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
            this.components = new System.ComponentModel.Container();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblCodLivro = new System.Windows.Forms.Label();
            this.lblCodigoLivro = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtQtdeEstoq = new System.Windows.Forms.TextBox();
            this.lblQtdEstoq = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPag = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.cbxCateg = new System.Windows.Forms.ComboBox();
            this.db_LivrariaDataSet1 = new Livraria.db_LivrariaDataSet1();
            this.dbLivrariaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_LivrariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLivrariaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlterar.Location = new System.Drawing.Point(700, 255);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 43);
            this.btnAlterar.TabIndex = 189;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblCodLivro
            // 
            this.lblCodLivro.AutoSize = true;
            this.lblCodLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodLivro.ForeColor = System.Drawing.Color.Red;
            this.lblCodLivro.Location = new System.Drawing.Point(156, 103);
            this.lblCodLivro.Name = "lblCodLivro";
            this.lblCodLivro.Size = new System.Drawing.Size(0, 24);
            this.lblCodLivro.TabIndex = 162;
            this.lblCodLivro.Visible = false;
            // 
            // lblCodigoLivro
            // 
            this.lblCodigoLivro.AutoSize = true;
            this.lblCodigoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoLivro.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoLivro.Location = new System.Drawing.Point(71, 103);
            this.lblCodigoLivro.Name = "lblCodigoLivro";
            this.lblCodigoLivro.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoLivro.TabIndex = 161;
            this.lblCodigoLivro.Text = "Código:";
            this.lblCodigoLivro.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.Location = new System.Drawing.Point(700, 305);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 43);
            this.btnExcluir.TabIndex = 190;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(75, 452);
            this.dgvLivro.MultiSelect = false;
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(604, 114);
            this.dgvLivro.TabIndex = 184;
            this.dgvLivro.DoubleClick += new System.EventHandler(this.dgvLivro_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(99, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 63);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa Por Livro";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(64, 28);
            this.txtBusca.MaxLength = 60;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(401, 29);
            this.txtBusca.TabIndex = 12;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(166, 229);
            this.txtISBN.MaxLength = 17;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(263, 29);
            this.txtISBN.TabIndex = 181;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblISBN.Location = new System.Drawing.Point(93, 229);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(57, 24);
            this.lblISBN.TabIndex = 180;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtQtdeEstoq
            // 
            this.txtQtdeEstoq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstoq.Location = new System.Drawing.Point(166, 192);
            this.txtQtdeEstoq.MaxLength = 60;
            this.txtQtdeEstoq.Name = "txtQtdeEstoq";
            this.txtQtdeEstoq.Size = new System.Drawing.Size(263, 29);
            this.txtQtdeEstoq.TabIndex = 179;
            // 
            // lblQtdEstoq
            // 
            this.lblQtdEstoq.AutoSize = true;
            this.lblQtdEstoq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdEstoq.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQtdEstoq.Location = new System.Drawing.Point(65, 192);
            this.lblQtdEstoq.Name = "lblQtdEstoq";
            this.lblQtdEstoq.Size = new System.Drawing.Size(85, 24);
            this.lblQtdEstoq.TabIndex = 178;
            this.lblQtdEstoq.Text = "Estoque:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(549, 155);
            this.txtValor.MaxLength = 60;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 29);
            this.txtValor.TabIndex = 177;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor.Location = new System.Drawing.Point(473, 155);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 24);
            this.lblValor.TabIndex = 176;
            this.lblValor.Text = "Valor:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(549, 229);
            this.txtPaginas.MaxLength = 4;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(130, 29);
            this.txtPaginas.TabIndex = 175;
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPag.Location = new System.Drawing.Point(449, 229);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(82, 24);
            this.lblPag.TabIndex = 174;
            this.lblPag.Text = "Páginas:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(700, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 43);
            this.btnSalvar.TabIndex = 173;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Location = new System.Drawing.Point(700, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 43);
            this.btnCancelar.TabIndex = 171;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Location = new System.Drawing.Point(700, 155);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 43);
            this.btnNovo.TabIndex = 170;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(549, 192);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(130, 29);
            this.txtAno.TabIndex = 169;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAno.Location = new System.Drawing.Point(482, 192);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(50, 24);
            this.lblAno.TabIndex = 168;
            this.lblAno.Text = "Ano:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(166, 155);
            this.txtTitulo.MaxLength = 60;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(263, 29);
            this.txtTitulo.TabIndex = 167;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitulo.Location = new System.Drawing.Point(86, 155);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 24);
            this.lblTitulo.TabIndex = 166;
            this.lblTitulo.Text = "Título:";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLivro.Location = new System.Drawing.Point(339, 43);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(150, 51);
            this.lblLivro.TabIndex = 163;
            this.lblLivro.Text = "Livros";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCateg.Location = new System.Drawing.Point(55, 294);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(95, 24);
            this.lblCateg.TabIndex = 191;
            this.lblCateg.Text = "Categoria:";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEdit.Location = new System.Drawing.Point(76, 338);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(74, 24);
            this.lblEdit.TabIndex = 194;
            this.lblEdit.Text = "Editora:";
            // 
            // txtEdit
            // 
            this.txtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(166, 333);
            this.txtEdit.MaxLength = 17;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(263, 29);
            this.txtEdit.TabIndex = 195;
            // 
            // cbxCateg
            // 
            this.cbxCateg.DataSource = this.db_LivrariaDataSet1;
            this.cbxCateg.DisplayMember = "tbl_Categoria.nm_Categoria";
            this.cbxCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCateg.FormattingEnabled = true;
            this.cbxCateg.Location = new System.Drawing.Point(166, 294);
            this.cbxCateg.Name = "cbxCateg";
            this.cbxCateg.Size = new System.Drawing.Size(263, 32);
            this.cbxCateg.TabIndex = 196;
            this.cbxCateg.TabStop = false;
            this.cbxCateg.ValueMember = "tbl_Categoria.cd_Categoria";
            // 
            // db_LivrariaDataSet1
            // 
            this.db_LivrariaDataSet1.DataSetName = "db_LivrariaDataSet1";
            this.db_LivrariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbLivrariaDataSet1BindingSource
            // 
            this.dbLivrariaDataSet1BindingSource.DataSource = this.db_LivrariaDataSet1;
            this.dbLivrariaDataSet1BindingSource.Position = 0;
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxCateg);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblCodLivro);
            this.Controls.Add(this.lblCodigoLivro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvLivro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtQtdeEstoq);
            this.Controls.Add(this.lblQtdEstoq);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.lblPag);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLivro);
            this.Name = "frmLivro";
            this.Size = new System.Drawing.Size(848, 620);
            this.Load += new System.EventHandler(this.frmLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_LivrariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLivrariaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblCodLivro;
        private System.Windows.Forms.Label lblCodigoLivro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtQtdeEstoq;
        private System.Windows.Forms.Label lblQtdEstoq;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.ComboBox cbxCateg;
        private db_LivrariaDataSet1 db_LivrariaDataSet1;
        private System.Windows.Forms.BindingSource dbLivrariaDataSet1BindingSource;
    }
}
