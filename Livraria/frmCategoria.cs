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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            lblCodigoCateg.Visible = false;
            lblCodCateg.Visible = false;
            lblCodLivro.Visible = false;
            lblCodLiv.Visible = false;
            lblTitulo.Visible = false;

            txtCateg.Enabled = false;
            txtTitulo.Visible = false;

            cbxCateg.Enabled = false;
            cbxCateg.Visible = false;

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtCateg.Enabled = true;

            cbxCateg.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;

            cbxCateg.Focus();
            txtBuscaCateg.Text = "";

            dgvCateg.DataSource = null;
        }

        private void limparCampos()
        {
            txtCateg.Clear();

            cbxCateg.SelectedIndex = -1;

            lblCodigoCateg.Visible = false;

            dgvCateg.DataSource = null;

            cbxCateg.Focus();
        }

        private void manipulaDadosCateg()
        {
            lblCodigoCateg.Visible = true;
            lblCodCateg.Visible = true;
            lblCodLivro.Visible = false;
            lblCodLiv.Visible = false;
            lblTitulo.Visible = false;

            txtCateg.Visible = true;
            txtTitulo.Visible = false;
            txtTitulo.Visible = false;

            cbxCateg.Enabled = false;
            cbxCateg.Visible = false;
        }

        private void manipulaDadosTit()
        {
            lblCodigoCateg.Visible = true;
            lblCodCateg.Visible = true;
            lblCodLivro.Visible = true;
            lblCodLiv.Visible = true;
            lblTitulo.Visible = true;

            txtCateg.Visible = false;
            txtTitulo.Visible = true;
            txtTitulo.Enabled = false;

            cbxCateg.Enabled = true;
            cbxCateg.Visible = true;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCateg.Text != "")
            {
                MessageBox.Show("Para alterar uma categoria informe o código da mesma.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtCateg.Focus();
            }
            else
            {
                try
                {
                    //string mudaCateg = "";
                    //string categoria = cbxCateg.Text;

                    //string strSQL = "select nm_Categoria from tbl_Categoria where nm_Categoria = '" + categoria + "'";

                    //cmd.CommandText = strSQL;
                    //cmd.Connection = cn;

                    //cn.Open();
                    //cmd.ExecuteNonQuery();

                    //if (cbxCateg.Text != mudaCateg)
                    //{
                    //    MessageBox.Show("Para alterar a categoria de um livro informe o código da mesma.!",
                    //                   "Atenção", MessageBoxButtons.OK,
                    //                   MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    string titulo = txtTitulo.Text;
                    //    int codCateg = Convert.ToInt32(lblCodCateg.Text);

                    //    cmd.CommandText = "update vw_PorTitulo set cd_Categoria = @cdc where cd_Livro = @cd_Livro";
                    //    cmd.Connection = cn;

                    //    cmd.Parameters.Add("@cd_Livro", SqlDbType.VarChar).Value = titulo;
                    //    cmd.Parameters.Add("@cde", SqlDbType.Int).Value = codCateg;

                    //    cmd.ExecuteNonQuery();
                    //    cmd.Parameters.Clear();
                    //}
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        public void carregaDataGridCateg()
        {
            manipulaDadosCateg();

            lblCodCateg.Text = dgvCateg.SelectedRows[0].Cells[0].Value.ToString();
            txtCateg.Text = dgvCateg.SelectedRows[0].Cells[1].Value.ToString();
        }

        public void carregaDataGridTit()
        {
            manipulaDadosTit();

            lblCodLiv.Text = dgvCateg.SelectedRows[0].Cells[0].Value.ToString();
            txtTitulo.Text = dgvCateg.SelectedRows[0].Cells[1].Value.ToString();
            lblCodCateg.Text = dgvCateg.SelectedRows[0].Cells[2].Value.ToString();
            cbxCateg.Text = dgvCateg.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txtBuscaCateg_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (txtBuscaCateg.Text != "")
            {
                try
                {
                    cn.Open();

                    cmd.CommandText = "select cd_Categoria, nm_Categoria from vw_PorTitulo where nm_Categoria like ('" + txtBuscaCateg.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dtt = new DataTable();
                    // recebendo os dados do select
                    da.SelectCommand = cmd;
                    // preenchendo o datatable
                    da.Fill(dtt);

                    dgvCateg.DataSource = dtt;
                    
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

        private void txtBuscaTit_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;

            if (txtBuscaTit.Text != "")
            {
                try
                {
                    cn.Open();

                    cmd.CommandText = "select cd_Livro, nm_Livro, cd_Categoria, nm_Categoria from vw_PorTitulo where nm_Livro like ('" + txtBuscaTit.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dtt = new DataTable();
                    // recebendo os dados do select
                    da.SelectCommand = cmd;
                    // preenchendo o datatable
                    da.Fill(dtt);

                    dgvCateg.DataSource = dtt;
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
        private void preencheCbxCateg()
        {
            cn.Open();

            try
            {
                cmd.CommandText = "select cd_Categoria, nm_Categoria from tbl_Categoria order by nm_Categoria desc";
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtt = new DataTable();
                // recebendo os dados do select
                // preenchendo o datatable
                dtt.Load(reader);
                DataRow row = dtt.NewRow(); // representa uma linha de dados em um datatable
                row["nm_Categoria"] = ""; // para nao gerar valor nulo e, consequentemente, evitar erro de execuçao
                //dtt.Rows.InsertAt(row, 0); // insere nova linha na coleçao no local especificado

                this.cbxCateg.DataSource = dtt;
                this.cbxCateg.ValueMember = "cd_Categoria";
                this.cbxCateg.DisplayMember = "nm_Categoria";

                reader.Close();
                reader.Dispose(); // libera o objeto da memoria

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

        private void dgvCateg_DoubleClick(object sender, EventArgs e)
        {
            manipulaDadosTit();
            preencheCbxCateg();
            if (txtBuscaCateg.Text != "")
            {
                carregaDataGridCateg();
            }
            else if (txtBuscaTit.Text != "")
            {
                carregaDataGridTit();
                txtBuscaTit.Clear();
            }
            habilitaCampos();
        }
    }
}
