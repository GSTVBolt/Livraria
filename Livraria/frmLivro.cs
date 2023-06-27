using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livraria
{
    public partial class frmLivro : UserControl
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        private void desabilitaCampos()
        {
            lblCodigoLivro.Visible = false;
            lblCodLivro.Visible = false;
            lblCateg.Visible = false;
            lblEdit.Visible = false;

            txtTitulo.Enabled = false;
            txtQtdeEstoq.Enabled = false;
            txtISBN.Enabled = false;
            txtValor.Enabled = false;
            txtAno.Enabled = false;
            txtPaginas.Enabled = false;
            txtEdit.Visible = false;

            cbxCateg.Visible = false;

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtTitulo.Enabled = true;
            txtQtdeEstoq.Enabled = true;
            txtISBN.Enabled = true;
            txtValor.Enabled = true;
            txtAno.Enabled = true;
            txtPaginas.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;

            txtTitulo.Focus();
            txtBusca.Text = "";

            dgvLivro.DataSource = null;
        }

        private void limparCampos()
        {
            txtTitulo.Clear();
            txtQtdeEstoq.Clear();
            txtISBN.Clear();
            txtValor.Clear();
            txtAno.Clear();
            txtPaginas.Clear();

            lblCodigoLivro.Visible = false;

            dgvLivro.DataSource = null;

            txtTitulo.Focus();
        }

        private void manipularDados()
        {
            lblCodigoLivro.Visible = true;
            lblCodLivro.Visible = true;
            lblCateg.Visible = true;
            lblEdit.Visible = true;

            txtTitulo.Enabled = true;
            txtQtdeEstoq.Enabled = true;
            txtISBN.Enabled = true;
            txtValor.Enabled = true;
            txtAno.Enabled = true;
            txtPaginas.Enabled = true;
            txtEdit.Visible = true;

            cbxCateg.Visible = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void frmLivro_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Título.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtTitulo.Focus();
            }
            else if (txtQtdeEstoq.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Estoque.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtQtdeEstoq.Focus();
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo ISBN.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtISBN.Focus();
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Valor.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtValor.Focus();
            }
            else if (txtAno.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Ano.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtAno.Focus();
            }
            else if (txtAno.Text.Length < 4)
            {
                MessageBox.Show("Obrigatório informar um Ano válido.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtAno.Focus();
            }
            else if (txtPaginas.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Páginas.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtPaginas.Focus();
            }
            else
            {
                try
                {
                    string tituloLivro = txtTitulo.Text;
                    string paginasLivro = txtPaginas.Text;
                    string valorLivro = txtValor.Text;
                    string qtdeEstoque = txtQtdeEstoq.Text;
                    string isbn = txtISBN.Text;
                    string ano = txtAno.Text;

                    string strSQL = "insert into tbl_Livro(nm_Livro, no_Paginas, vl_Livro, qt_Estoque, no_Isbn, dt_AnoPublica)" +
                                    "values(@nm_Livro, @no_Paginas, @vl_Livro, @qt_Estoque, @no_Isbn, @dt_AnoPublica)" +
                                    "set @cd = SCOPE_IDENTITY()";
                    cmd.CommandText = strSQL;
                    cmd.Connection = cn;

                    cmd.Parameters.Add("@nm_Livro", SqlDbType.VarChar).Value = tituloLivro;
                    cmd.Parameters.Add("@no_Paginas", SqlDbType.VarChar).Value = paginasLivro;
                    cmd.Parameters.Add("@vl_Livro", SqlDbType.Decimal).Value = valorLivro;
                    cmd.Parameters.Add("@qt_Estoque", SqlDbType.Int).Value = qtdeEstoque;
                    cmd.Parameters.Add("@no_Isbn", SqlDbType.Char).Value = isbn;
                    cmd.Parameters.Add("@dt_AnoPublica", SqlDbType.Char).Value = ano;
                    cmd.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;
                    //cmd.Parameters.AddWithValue("@cdCateg", 0).Direction = ParameterDirection.Output;
                    //cmd.Parameters.AddWithValue("@cdEdit", 0).Direction = ParameterDirection.Output;

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
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Título.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtTitulo.Focus();
            }
            else if (txtQtdeEstoq.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Estoque.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtQtdeEstoq.Focus();
            }
            else if (txtISBN.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo ISBN.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtISBN.Focus();
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Valor.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtValor.Focus();
            }
            else if (txtAno.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Ano.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtAno.Focus();
            }
            else if (txtAno.Text.Length < 4)
            {
                MessageBox.Show("Obrigatório informar um Ano válido.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtAno.Focus();
            }
            else if (txtPaginas.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Páginas.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtPaginas.Focus();
            }
            else if (cbxCateg.Text == "" && cbxCateg.SelectedIndex < 0)
            {
                MessageBox.Show("Obrigatório informar o campo Categoria.!",
                               "Atenção", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int codLivro = Convert.ToInt32(lblCodLivro.Text);
                    string tituloLivro = txtTitulo.Text;
                    string paginasLivro = txtPaginas.Text;
                    string valorLivro = txtValor.Text;
                    string qtdeEstoque = txtQtdeEstoq.Text;
                    string isbn = txtISBN.Text;
                    string ano = txtAno.Text;

                    string strSQL = "update tbl_Livro set nm_Livro = @nm_Livro, no_Paginas = @no_Paginas, vl_Livro = @vl_Livro," +
                                    "qt_Estoque = @qt_Estoque, no_Isbn = @no_Isbn, dt_AnoPublica = @dt_AnoPublica where cd_Livro = @cdl";

                    cmd.CommandText = strSQL;
                    cmd.Connection = cn;

                    cmd.Parameters.Add("@nm_Livro", SqlDbType.VarChar).Value = tituloLivro;
                    cmd.Parameters.Add("@no_Paginas", SqlDbType.VarChar).Value = paginasLivro;
                    cmd.Parameters.Add("@vl_Livro", SqlDbType.Decimal).Value = valorLivro;
                    cmd.Parameters.Add("@qt_Estoque", SqlDbType.Int).Value = qtdeEstoque;
                    cmd.Parameters.Add("@no_Isbn", SqlDbType.Char).Value = isbn;
                    cmd.Parameters.Add("@dt_AnoPublica", SqlDbType.Char).Value = ano;
                    cmd.Parameters.Add("@cdl", SqlDbType.Int).Value = codLivro;
                    

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Os dados foram alterados com sucesso !!!.",
                                    "Alteração de Dados Concluida", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtTitulo.Focus();
                    limparCampos();
                    desabilitaCampos();
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    
                    cmd.CommandText = "select * from vw_PorTitulo where nm_Livro like ('" + txtBusca.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dtt = new DataTable();
                    // recebendo os dados do select
                    da.SelectCommand = cmd;
                    // preenchendo o datatable
                    da.Fill(dtt);

                    dgvLivro.DataSource = dtt;
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
                dgvLivro.DataSource = null;
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

        private void carregaLivro()
        {
            manipularDados();
            preencheCbxCateg();

            lblCodLivro.Text = dgvLivro.SelectedRows[0].Cells[0].Value.ToString();
            txtTitulo.Text = dgvLivro.SelectedRows[0].Cells[1].Value.ToString();
            txtPaginas.Text = dgvLivro.SelectedRows[0].Cells[2].Value.ToString();
            txtValor.Text = dgvLivro.SelectedRows[0].Cells[3].Value.ToString();
            txtQtdeEstoq.Text = dgvLivro.SelectedRows[0].Cells[4].Value.ToString();
            txtISBN.Text = dgvLivro.SelectedRows[0].Cells[5].Value.ToString();
            txtAno.Text = dgvLivro.SelectedRows[0].Cells[6].Value.ToString();
            cbxCateg.Text = dgvLivro.SelectedRows[0].Cells[9].Value.ToString();
            txtEdit.Text = dgvLivro.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void dgvLivro_DoubleClick(object sender, EventArgs e)
        {
            carregaLivro();
            txtBusca.Clear();
        }
    }
}
