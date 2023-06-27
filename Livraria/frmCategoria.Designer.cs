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
            this.lblCateg = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblCodCateg = new System.Windows.Forms.Label();
            this.lblCodigoCateg = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvCateg = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaTit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCateg)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCateg.Location = new System.Drawing.Point(57, 168);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(95, 24);
            this.lblCateg.TabIndex = 220;
            this.lblCateg.Text = "Categoria:";
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
            // 
            // lblCodCateg
            // 
            this.lblCodCateg.AutoSize = true;
            this.lblCodCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCateg.ForeColor = System.Drawing.Color.Red;
            this.lblCodCateg.Location = new System.Drawing.Point(142, 79);
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
            this.lblCodigoCateg.Location = new System.Drawing.Point(57, 79);
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
            // txtCateg
            // 
            this.txtCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateg.Location = new System.Drawing.Point(170, 168);
            this.txtCateg.MaxLength = 20;
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(263, 29);
            this.txtCateg.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaTit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(90, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 63);
            this.groupBox1.TabIndex = 212;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Categoria";
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.lblCateg);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblCodCateg;
        private System.Windows.Forms.Label lblCodigoCateg;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvCateg;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtCateg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaTit;
    }
}
