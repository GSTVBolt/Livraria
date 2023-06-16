using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;

namespace Livraria
{
    public partial class frmFuncionario : UserControl
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        // Esbalecendo conexao com o bdd sql server

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dt;

        private void desebalitaCampos()
        {
            lblCodigo.Visible = false;
            lblCod.Visible = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false; 
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
            txtBusca.Text = "";
            dgvFunc.DataSource = null;
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtBusca.Clear();
            lblCodigo.Visible = false;
            lblCod.Visible = false; 
            dgvFunc.DataSource = null;
            rdbAtivo.Checked = true;

            txtNome.Focus();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            desebalitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desebalitaCampos();
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", 
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no mínimo 8 digitos.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbInativo.Checked)
            {
                MessageBox.Show("Impossível cadastrar um funcionário se o status estiver INATIVO.",
                                "Erro ao tentar Salvar o registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;
                    string strSql = "insert into tbl_Atendente(ds_login, ds_senha, nm_atendente, ds_status)" +
                                    "values(@login, @senha, @atendente, 1)";
                    cmd.CommandText = strSql;
                    cmd.Connection = cn;
                    cmd.Parameters.Add("@login", SqlDbType.Char).Value = login;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Os dados foram gravados com sucesso !!!.",
                                    "Inserção de Dados Concluida", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtSenha.Focus();
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from tbl_Atendente where nm_atendente like ('" + txtBusca.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dtt = new DataTable();

                    // recebendo os dados do select
                    da.SelectCommand = cmd;
                    // preenchendo o datatable
                    da.Fill(dtt);

                    dgvFunc.DataSource = dtt;
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dgvFunc.DataSource = null;
            }
        }

        private void manipularDados()
        {
            lblCodigo.Visible = true;
            lblCod.Visible = true;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;

            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void carregaAtendente()
        {
            lblCod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();  
            txtLogin.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dgvFunc.SelectedRows[0].Cells[3].Value.ToString();

            string valor = dgvFunc.SelectedRows[0].Cells[4].Value.ToString();
            //MessageBox.Show(valor);

            if (valor == "True")
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }

            manipularDados();
        }

        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaAtendente();
            txtBusca.Clear();
            if (rdbAtivo.Checked)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no mínimo 8 digitos.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbInativo.Checked)
            {
                MessageBox.Show("Para INATIVAR um funcionário, é preciso clicar no botão REMOVER.",
                                "Erro na operação", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;
                    int codAtendente = Convert.ToInt32(lblCod.Text);
                    string strSql = "update tbl_atendente set ds_login = @login, ds_senha = @senha, nm_atendente = @atendente, " +
                        " ds_status = 1 where cd_atendente = @cda";
                    cmd.CommandText = strSql;
                    cmd.Connection = cn;
                    cmd.Parameters.Add("@login", SqlDbType.Char).Value = login;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@cda", SqlDbType.Int).Value = codAtendente;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Os dados foram alterados com sucesso !!!.",
                                    "Alteração de Dados Concluida", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtNome.Focus();
                    limparCampos();
                    desebalitaCampos();
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
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no mínimo 8 digitos.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (rdbAtivo.Checked)
            {
                MessageBox.Show("Para remover o registro você precisa alterar o status para INATIVO.",
                                "Erro ao tentar excluir", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover este registro?",
                                                        "Exclusão de registro", MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int status = Convert.ToInt32(lblCod.Text);
                        string strSql = "update tbl_atendente set ds_status = 0 where cd_atendente = @status";

                        cmd.CommandText = strSql;
                        cmd.Connection = cn;

                        cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        MessageBox.Show("A exclusão foi executada com sucesso !!!.",
                                        "Exclusão do Registro Concluida", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        txtNome.Focus();
                        limparCampos();
                        desebalitaCampos();
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
        }
    }
}
