namespace Livraria
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
            this.pneMenu = new System.Windows.Forms.Panel();
            this.pneLogo = new System.Windows.Forms.Panel();
            this.lbl_LivLeitura = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFone = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.principal1 = new Livraria.principal();
            this.pneMenu.SuspendLayout();
            this.pneLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pneMenu
            // 
            this.pneMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pneMenu.Controls.Add(this.btnCaixa);
            this.pneMenu.Controls.Add(this.btnPedido);
            this.pneMenu.Controls.Add(this.btnAutor);
            this.pneMenu.Controls.Add(this.btnEditora);
            this.pneMenu.Controls.Add(this.btnCat);
            this.pneMenu.Controls.Add(this.btnLivros);
            this.pneMenu.Controls.Add(this.btnFone);
            this.pneMenu.Controls.Add(this.btnCliente);
            this.pneMenu.Controls.Add(this.btnFunc);
            this.pneMenu.Controls.Add(this.pneLogo);
            this.pneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pneMenu.Location = new System.Drawing.Point(0, 0);
            this.pneMenu.Name = "pneMenu";
            this.pneMenu.Size = new System.Drawing.Size(220, 556);
            this.pneMenu.TabIndex = 0;
            // 
            // pneLogo
            // 
            this.pneLogo.BackColor = System.Drawing.SystemColors.Desktop;
            this.pneLogo.Controls.Add(this.lbl_LivLeitura);
            this.pneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pneLogo.Location = new System.Drawing.Point(0, 0);
            this.pneLogo.Name = "pneLogo";
            this.pneLogo.Size = new System.Drawing.Size(220, 87);
            this.pneLogo.TabIndex = 0;
            // 
            // lbl_LivLeitura
            // 
            this.lbl_LivLeitura.AutoSize = true;
            this.lbl_LivLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LivLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LivLeitura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LivLeitura.Location = new System.Drawing.Point(62, 18);
            this.lbl_LivLeitura.Name = "lbl_LivLeitura";
            this.lbl_LivLeitura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LivLeitura.Size = new System.Drawing.Size(96, 50);
            this.lbl_LivLeitura.TabIndex = 1;
            this.lbl_LivLeitura.Text = "Livraria\r\n   Leitura\r\n";
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaixa.Image = global::Livraria.Properties.Resources.cash;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 407);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCaixa.Size = new System.Drawing.Size(220, 40);
            this.btnCaixa.TabIndex = 9;
            this.btnCaixa.Text = " Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedido.Image = global::Livraria.Properties.Resources.request_2;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(0, 367);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(220, 40);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = " Pedidos";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnAutor
            // 
            this.btnAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutor.Image = global::Livraria.Properties.Resources.autor;
            this.btnAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.Location = new System.Drawing.Point(0, 327);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAutor.Size = new System.Drawing.Size(220, 40);
            this.btnAutor.TabIndex = 7;
            this.btnAutor.Text = " Autores";
            this.btnAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatAppearance.BorderSize = 0;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditora.Image = global::Livraria.Properties.Resources.design_editorial;
            this.btnEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.Location = new System.Drawing.Point(0, 287);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEditora.Size = new System.Drawing.Size(220, 40);
            this.btnEditora.TabIndex = 6;
            this.btnEditora.Text = " Editora";
            this.btnEditora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCat
            // 
            this.btnCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCat.Image = global::Livraria.Properties.Resources.category;
            this.btnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.Location = new System.Drawing.Point(0, 247);
            this.btnCat.Name = "btnCat";
            this.btnCat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCat.Size = new System.Drawing.Size(220, 40);
            this.btnCat.TabIndex = 5;
            this.btnCat.Text = " Categoria";
            this.btnCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLivros.Image = global::Livraria.Properties.Resources.configuracoes;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(0, 207);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(220, 40);
            this.btnLivros.TabIndex = 4;
            this.btnLivros.Text = " Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnFone
            // 
            this.btnFone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFone.FlatAppearance.BorderSize = 0;
            this.btnFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFone.Image = global::Livraria.Properties.Resources.phone;
            this.btnFone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.Location = new System.Drawing.Point(0, 167);
            this.btnFone.Name = "btnFone";
            this.btnFone.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFone.Size = new System.Drawing.Size(220, 40);
            this.btnFone.TabIndex = 3;
            this.btnFone.Text = " Telefones";
            this.btnFone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Image = global::Livraria.Properties.Resources.client;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 127);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(220, 40);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = " Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFunc
            // 
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFunc.Image = global::Livraria.Properties.Resources.func;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.Location = new System.Drawing.Point(0, 87);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFunc.Size = new System.Drawing.Size(220, 40);
            this.btnFunc.TabIndex = 1;
            this.btnFunc.Text = " Funcionário";
            this.btnFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = true;
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(219, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(829, 595);
            this.principal1.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 556);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.pneMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.pneMenu.ResumeLayout(false);
            this.pneLogo.ResumeLayout(false);
            this.pneLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pneMenu;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pneLogo;
        private System.Windows.Forms.Label lbl_LivLeitura;
        private principal principal1;
    }
}