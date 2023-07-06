using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livraria
{
    public partial class frmPedidos : UserControl
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        // Esbalecendo conexao com o bdd sql server

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dt;

        private void desabilitaCampos()
        {
            lblNovoPedido.Visible = false;
            lblProduto.Visible = false;
            lblQtde.Visible = false;
            lblValor.Visible = false;
            lblValor2.Visible = false;
            lblDesc.Visible = false;
            lblValorPg.Visible = false;
            lblFormPag.Visible = false;
            lblDataVenc.Visible = false;
            lblLinha1.Visible = false;
            lblLinha2.Visible = false;

            txtQtde.Visible = false;
            txtValor.Visible = false;
            txtValor2.Visible = false;
            txtDesc.Visible = false;
            txtValorPg.Visible = false;

            cbxProd.Visible = false;
            cbxFormPag.Visible = false;

            dtpVenc.Visible = false;

            btnNovoItem.Visible = false;
            btnFinalizar.Visible = false;
        }

        private void preencheCbxCliente()
        {
            try
            {
                string strSQL = "select cd_Cliente, nm_Cliente from tbl_Cliente order by nm_Cliente asc";
                SqlCommand sqlCommand = new SqlCommand(strSQL, cn);

                cn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter(sqlCommand);
                adpt.Fill(ds);

                this.cbxCliente.DataSource = ds.Tables[0];
                this.cbxCliente.ValueMember = "cd_Cliente";
                this.cbxCliente.DisplayMember = "nm_Cliente";

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            finally
            {
                cn.Close();
            }
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            preencheCbxCliente();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
        }
    }
}
