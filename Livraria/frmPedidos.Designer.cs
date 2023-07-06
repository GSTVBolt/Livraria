namespace Livraria
{
    partial class frmPedidos
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
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.lblNovoPedido = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblLinha1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.cbxFormPag = new System.Windows.Forms.ComboBox();
            this.lblFormPag = new System.Windows.Forms.Label();
            this.lblDataVenc = new System.Windows.Forms.Label();
            this.dtpVenc = new System.Windows.Forms.DateTimePicker();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtValorPg = new System.Windows.Forms.TextBox();
            this.lblValorPg = new System.Windows.Forms.Label();
            this.lblLinha2 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.db_LivrariaDataSet = new Livraria.db_LivrariaDataSet();
            this.tbl_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ClienteTableAdapter = new Livraria.db_LivrariaDataSetTableAdapters.tbl_ClienteTableAdapter();
            this.tableAdapterManager = new Livraria.db_LivrariaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.db_LivrariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPedidos.Location = new System.Drawing.Point(298, 22);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(189, 51);
            this.lblPedidos.TabIndex = 1;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCliente.Location = new System.Drawing.Point(43, 89);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoPedido.Location = new System.Drawing.Point(572, 83);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(122, 38);
            this.btnNovoPedido.TabIndex = 13;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // lblNovoPedido
            // 
            this.lblNovoPedido.AutoSize = true;
            this.lblNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoPedido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNovoPedido.Location = new System.Drawing.Point(43, 136);
            this.lblNovoPedido.Name = "lblNovoPedido";
            this.lblNovoPedido.Size = new System.Drawing.Size(120, 24);
            this.lblNovoPedido.TabIndex = 14;
            this.lblNovoPedido.Text = "Novo Pedido";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblProduto.Location = new System.Drawing.Point(103, 185);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(81, 24);
            this.lblProduto.TabIndex = 17;
            this.lblProduto.Text = "Produto:";
            // 
            // cbxProd
            // 
            this.cbxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbxProd.Location = new System.Drawing.Point(190, 185);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(434, 32);
            this.cbxProd.TabIndex = 142;
            this.cbxProd.TabStop = false;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(190, 231);
            this.txtQtde.MaxLength = 60;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(156, 29);
            this.txtQtde.TabIndex = 144;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQtde.Location = new System.Drawing.Point(71, 231);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(113, 24);
            this.lblQtde.TabIndex = 143;
            this.lblQtde.Text = "Quantidade:";
            // 
            // lblLinha1
            // 
            this.lblLinha1.AutoSize = true;
            this.lblLinha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha1.ForeColor = System.Drawing.Color.Silver;
            this.lblLinha1.Location = new System.Drawing.Point(186, 136);
            this.lblLinha1.Name = "lblLinha1";
            this.lblLinha1.Size = new System.Drawing.Size(526, 24);
            this.lblLinha1.TabIndex = 145;
            this.lblLinha1.Text = "---------------------------------------------------------------------------------" +
    "-----";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(190, 277);
            this.txtValor.MaxLength = 60;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 29);
            this.txtValor.TabIndex = 147;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor.Location = new System.Drawing.Point(125, 277);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 24);
            this.lblValor.TabIndex = 146;
            this.lblValor.Text = "Valor:";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovoItem.Location = new System.Drawing.Point(355, 271);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(122, 38);
            this.btnNovoItem.TabIndex = 148;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            // 
            // cbxFormPag
            // 
            this.cbxFormPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormPag.FormattingEnabled = true;
            this.cbxFormPag.Items.AddRange(new object[] {
            "Á vista",
            "Á prazo"});
            this.cbxFormPag.Location = new System.Drawing.Point(525, 365);
            this.cbxFormPag.Name = "cbxFormPag";
            this.cbxFormPag.Size = new System.Drawing.Size(169, 32);
            this.cbxFormPag.TabIndex = 152;
            this.cbxFormPag.TabStop = false;
            // 
            // lblFormPag
            // 
            this.lblFormPag.AutoSize = true;
            this.lblFormPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFormPag.Location = new System.Drawing.Point(352, 371);
            this.lblFormPag.Name = "lblFormPag";
            this.lblFormPag.Size = new System.Drawing.Size(167, 20);
            this.lblFormPag.TabIndex = 153;
            this.lblFormPag.Text = "Forma de Pagamento:";
            // 
            // lblDataVenc
            // 
            this.lblDataVenc.AutoSize = true;
            this.lblDataVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDataVenc.Location = new System.Drawing.Point(360, 411);
            this.lblDataVenc.Name = "lblDataVenc";
            this.lblDataVenc.Size = new System.Drawing.Size(159, 20);
            this.lblDataVenc.TabIndex = 154;
            this.lblDataVenc.Text = "Data de Vencimento:";
            // 
            // dtpVenc
            // 
            this.dtpVenc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVenc.Location = new System.Drawing.Point(525, 411);
            this.dtpVenc.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtpVenc.Name = "dtpVenc";
            this.dtpVenc.Size = new System.Drawing.Size(169, 30);
            this.dtpVenc.TabIndex = 155;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(144, 373);
            this.txtValor2.MaxLength = 60;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(156, 29);
            this.txtValor2.TabIndex = 157;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor2.Location = new System.Drawing.Point(79, 373);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(59, 24);
            this.lblValor2.TabIndex = 156;
            this.lblValor2.Text = "Valor:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinalizar.Location = new System.Drawing.Point(572, 459);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(122, 38);
            this.btnFinalizar.TabIndex = 158;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(144, 415);
            this.txtDesc.MaxLength = 60;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(156, 29);
            this.txtDesc.TabIndex = 160;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDesc.Location = new System.Drawing.Point(43, 415);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(95, 24);
            this.lblDesc.TabIndex = 159;
            this.lblDesc.Text = "Desconto:";
            // 
            // txtValorPg
            // 
            this.txtValorPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPg.Location = new System.Drawing.Point(144, 459);
            this.txtValorPg.MaxLength = 60;
            this.txtValorPg.Name = "txtValorPg";
            this.txtValorPg.Size = new System.Drawing.Size(156, 29);
            this.txtValorPg.TabIndex = 162;
            // 
            // lblValorPg
            // 
            this.lblValorPg.AutoSize = true;
            this.lblValorPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValorPg.Location = new System.Drawing.Point(30, 459);
            this.lblValorPg.Name = "lblValorPg";
            this.lblValorPg.Size = new System.Drawing.Size(108, 24);
            this.lblValorPg.TabIndex = 161;
            this.lblValorPg.Text = "Valor Pago:";
            // 
            // lblLinha2
            // 
            this.lblLinha2.AutoSize = true;
            this.lblLinha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha2.ForeColor = System.Drawing.Color.Silver;
            this.lblLinha2.Location = new System.Drawing.Point(43, 326);
            this.lblLinha2.Name = "lblLinha2";
            this.lblLinha2.Size = new System.Drawing.Size(670, 24);
            this.lblLinha2.TabIndex = 163;
            this.lblLinha2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
            // 
            // cbxCliente
            // 
            this.cbxCliente.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(122, 86);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(434, 32);
            this.cbxCliente.TabIndex = 164;
            this.cbxCliente.TabStop = false;
            // 
            // db_LivrariaDataSet
            // 
            this.db_LivrariaDataSet.DataSetName = "db_LivrariaDataSet";
            this.db_LivrariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ClienteBindingSource
            // 
            this.tbl_ClienteBindingSource.DataMember = "tbl_Cliente";
            this.tbl_ClienteBindingSource.DataSource = this.db_LivrariaDataSet;
            // 
            // tbl_ClienteTableAdapter
            // 
            this.tbl_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_ClienteTableAdapter = this.tbl_ClienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = Livraria.db_LivrariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblLinha2);
            this.Controls.Add(this.txtValorPg);
            this.Controls.Add(this.lblValorPg);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.dtpVenc);
            this.Controls.Add(this.lblDataVenc);
            this.Controls.Add(this.lblFormPag);
            this.Controls.Add(this.cbxFormPag);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblLinha1);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.cbxProd);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblNovoPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblPedidos);
            this.Name = "frmPedidos";
            this.Size = new System.Drawing.Size(848, 620);
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_LivrariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Label lblNovoPedido;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblLinha1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.ComboBox cbxFormPag;
        private System.Windows.Forms.Label lblFormPag;
        private System.Windows.Forms.Label lblDataVenc;
        private System.Windows.Forms.DateTimePicker dtpVenc;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtValorPg;
        private System.Windows.Forms.Label lblValorPg;
        private System.Windows.Forms.Label lblLinha2;
        private System.Windows.Forms.ComboBox cbxCliente;
        private db_LivrariaDataSet db_LivrariaDataSet;
        private System.Windows.Forms.BindingSource tbl_ClienteBindingSource;
        private db_LivrariaDataSetTableAdapters.tbl_ClienteTableAdapter tbl_ClienteTableAdapter;
        private db_LivrariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
