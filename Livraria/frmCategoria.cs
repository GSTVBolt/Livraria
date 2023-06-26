using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class frmCategoria : UserControl
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        private void desabilitaCampos()
        {
            lblCodigoCateg.Enabled = false;

            txtCateg.Enabled = false;

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtCateg.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;

            txtCateg.Focus();
            txtBuscaTit.Text = "";

            dgvCateg.DataSource = null;
        }

        private void limparCampos()
        {
            txtCateg.Clear();

            lblCodigoCateg.Visible = false;

            dgvCateg.DataSource = null;

            txtCateg.Focus();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCateg.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Categoria.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtCateg.Focus();
            }
            else
            {
                try
                {
                    string categoria = txtCateg.Text;

                    string strSQL = "insert into tbl_Categoria(nm_Categoria) values(@nm_Categoria)";

                    cmd.CommandText = strSQL;
                    cmd.Connection = cn;

                    cmd.Parameters.Add("@nm_Categoria", SqlDbType.VarChar).Value = categoria;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    MessageBox.Show("Os dados foram gravados com sucesso !!!.",
                                       "Inserção de Dados Concluida", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                    cn.Close();
                    limparCampos();
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
        }

        public void carregaDataGrid(string sqlQueryString)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dtt = new DataTable();
            dgvCateg.DataSource = null;
            cmd.Connection = null;
            dgvCateg.Columns.Clear(); // <-- limpa colunas
            //---------------------------------
            cmd.CommandText = sqlQueryString;
            cmd.Connection = cn;
            dtt = new DataTable();
            dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dtt);
            dgvCateg.DataSource = dtt;
            dgvCateg.AllowUserToAddRows = false; // remove linha nula
            dgvCateg.ReadOnly = true;
            dgvCateg.Columns[0].Visible = false;
            dgvCateg.Columns[1].Width = 340;
            dgvCateg.Columns[3].Width = 55;
            dgvCateg.Columns[4].Width = 50;
            dgvCateg.Columns[5].Width = 80;
            //// insere botão edita no datagridview
            //editButton = new DataGridViewButtonColumn();
            //editButton.HeaderText = "Edita";
            //editButton.Text = "Edita";
            //editButton.UseColumnTextForButtonValue = true;
            //editButton.Width = 80;
            //dgvItens.Columns.Add(editButton);
            //// insere botão delete no datagridview
            //deleteButton = new DataGridViewButtonColumn();
            //deleteButton.HeaderText = "Deleta";
            //deleteButton.Text = "Deleta";
            //deleteButton.UseColumnTextForButtonValue = true;
            //deleteButton.Width = 80;
            //dgvItens.Columns.Add(deleteButton);
        }

        private void txtBuscaTit_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaTit.Text != "")
            {
                try
                {
                    cn.Open();
                    string strSQl = "select * from vw_PorTitulo where nm_Livro like ('" + txtBuscaTit.Text + "%')";
                    carregaDataGrid(strSQl);
                    //cmd.Connection = cn;

                    //SqlDataAdapter da = new SqlDataAdapter();
                    //DataTable dtt = new DataTable();

                    //// recebendo os dados do select
                    //da.SelectCommand = cmd;
                    //// preenchendo o datatable
                    //da.Fill(dtt);

                    //dgvCateg.DataSource = dtt;
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
            else
            {
                dgvCateg.DataSource = null;
            }
        }
    }
}
