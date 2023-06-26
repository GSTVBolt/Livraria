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

namespace Livraria
{
    public partial class frmCliente : UserControl
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        private void desabilitaCampos()
        {
            lblCodigo.Visible = false;
            lblCod.Visible = false;

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtLograd.Enabled = false;
            txtComplemt.Enabled = false;
            txtCidade.Enabled = false;  
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;

            cbxPessoa.Enabled = false;
            cbxUF.Enabled = false; 
            
            maskTxtTel.Enabled = false;
            maskTxtCPF.Enabled = false;
            maskTxtCEP.Enabled = false; 

            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtLograd.Enabled = true;
            txtComplemt.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;

            cbxPessoa.Enabled = true;
            cbxUF.Enabled = true;

            maskTxtTel.Enabled = true;
            maskTxtCPF.Enabled = true;
            maskTxtCEP.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
            txtBusca.Text = "";

            dgvClient.DataSource = null;
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtLograd.Clear();
            txtComplemt.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtBusca.Clear();

            cbxPessoa.SelectedIndex = -1;
            cbxUF.SelectedIndex = -1;

            maskTxtTel.Clear();
            maskTxtCPF.Clear();
            maskTxtCEP.Clear();

            lblCodigo.Visible = false;
            lblCod.Visible = false;

            dgvClient.DataSource = null;

            rdbAtivo.Checked = true;

            txtNome.Focus();
        }

        private void manipularDados()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtLograd.Enabled = true;
            txtComplemt.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;

            cbxPessoa.Enabled = true;
            cbxUF.Enabled = true;

            maskTxtTel.Enabled = true;
            maskTxtCPF.Enabled = true;
            maskTxtCEP.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void desabilitaCNPJ()
        {
            lblCNPJ.Visible = false;
            maskTxtCNPJ.Visible = false;
        }

        private void cbxPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPessoa.SelectedIndex == -1) // se nao houver nada selecionado
            {
                desabilitaCNPJ();
            }
            else if (cbxPessoa.SelectedIndex == 0) // se estiver selecionado fisica
            {
                desabilitaCNPJ();
            }
            else
            {
                lblCNPJ.Visible = true;
                maskTxtCNPJ.Visible = true;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
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
            if(rdbInativo.Checked)
            {
                MessageBox.Show("Para gravar um cliente você precisa marcar o botão ATIVO",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                rdbAtivo.Checked = true;
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Email.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (cbxPessoa.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o tipo de Pessoa.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (cbxPessoa.SelectedIndex == 0 && maskTxtCPF.Text.Length < 11)
            {
                    MessageBox.Show("Obrigatório informar um CPF válido.!",
                                    "Atenção", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    maskTxtCPF.Focus();
            }
            else if (cbxPessoa.SelectedIndex == 1 && maskTxtCNPJ.Text.Length < 14)
            {
                    MessageBox.Show("Obrigatório informar um CNPJ válido.!",
                                    "Atenção", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    maskTxtCNPJ.Focus();
            }
            else if (txtLograd.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Logradouro.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtLograd.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cidade.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtCidade.Focus();
            }
            else if (maskTxtTel.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Telefone.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                maskTxtTel.Focus();
            }
            else if (maskTxtTel.Text.Length < 11)
            {
                MessageBox.Show("Obrigatório informar um Telefone válido.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                maskTxtTel.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Número do Logradouro.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtNumero.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Bairro.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtBairro.Focus();
            }
            else if (maskTxtCEP.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório informar o campo CEP.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                maskTxtCEP.Focus();
            }
            else if (cbxUF.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o Estado.!",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
               
                try
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string cpf;
                    string cnpj;
                    string logradouro = txtLograd.Text;
                    string numero = txtNumero.Text;
                    string complemento = txtComplemt.Text;
                    string bairro = txtBairro.Text;
                    string cidade = txtCidade.Text;
                    string uf = cbxUF.SelectedItem.ToString();
                    string cep = maskTxtCEP.Text;
                    string pessoa;

                    if (cbxPessoa.SelectedIndex == 0)
                    {
                        pessoa = "F";
                        cpf = maskTxtCPF.Text;
                        cnpj = "";
                    }
                    else
                    {
                        pessoa = "J";
                        cnpj = maskTxtCNPJ.Text;
                        cpf = "";
                    }

                    string strSQL = "insert into tbl_cliente(nm_cliente, ds_email, no_cpf, no_cnpj, nm_logradouro, no_logradouro," +
                                    "ds_complemento, nm_bairro, sg_uf, no_cep, nm_cidade, ds_pessoa, ds_status)" +
                                    "values(@nm_Cliente, @ds_Email, @no_CPF, @no_CNPJ, @nm_Logradouro, @no_Logradouro," +
                                    "@ds_Complemento, @nm_Bairro, @sg_UF, @no_CEP, @nm_Cidade, @ds_Pessoa, 1) " +
                                    "set @cd = SCOPE_IDENTITY()";

                    cmd.CommandText = strSQL;
                    cmd.Connection = cn;

                    cmd.Parameters.Add("@nm_Cliente", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@ds_Email", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@no_CPF", SqlDbType.Char).Value = cpf;
                    cmd.Parameters.Add("@no_CNPJ", SqlDbType.Char).Value = cnpj;
                    cmd.Parameters.Add("@nm_Logradouro", SqlDbType.VarChar).Value = logradouro;
                    cmd.Parameters.Add("@no_logradouro", SqlDbType.VarChar).Value = numero;
                    cmd.Parameters.Add("@ds_Complemento", SqlDbType.VarChar).Value = complemento;
                    cmd.Parameters.Add("@nm_Bairro", SqlDbType.VarChar).Value = bairro;
                    cmd.Parameters.Add("@sg_UF", SqlDbType.Char).Value = uf;
                    cmd.Parameters.Add("@no_CEP", SqlDbType.Char).Value = cep;
                    cmd.Parameters.Add("@nm_Cidade", SqlDbType.VarChar).Value = cidade;
                    cmd.Parameters.Add("@ds_Pessoa", SqlDbType.Char).Value = pessoa;
                    cmd.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    

                    int cd = Convert.ToInt32(cmd.Parameters["@cd"].Value);
                    string telefone = maskTxtTel.Text;

                    cmd.CommandText = "insert into tbl_telefone(cd_Cliente, no_Telefone) values('" + cd + "', '" + telefone + "')";
                    cmd.Connection = cn;

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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from vw_ConsCli where nm_Cliente like ('" + txtBusca.Text + "%')";
                    cmd.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dtt = new DataTable();

                    // recebendo os dados do select
                    da.SelectCommand = cmd;
                    // preenchendo o datatable
                    da.Fill(dtt);

                    dgvClient.DataSource = dtt;
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
                dgvClient.DataSource = null;
            }
        }

        private void carregaAtendente()
        {
            manipularDados();

            lblCod.Text = dgvClient.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvClient.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dgvClient.SelectedRows[0].Cells[2].Value.ToString();
            maskTxtCPF.Text = dgvClient.SelectedRows[0].Cells[3].Value.ToString();
            maskTxtCNPJ.Text = dgvClient.SelectedRows[0].Cells[4].Value.ToString();
            txtLograd.Text = dgvClient.SelectedRows[0].Cells[5].Value.ToString();
            txtNumero.Text = dgvClient.SelectedRows[0].Cells[6].Value.ToString();
            txtComplemt.Text = dgvClient.SelectedRows[0].Cells[7].Value.ToString();
            txtBairro.Text = dgvClient.SelectedRows[0].Cells[8].Value.ToString();
            txtCidade.Text = dgvClient.SelectedRows[0].Cells[9].Value.ToString();
            cbxUF.Text = dgvClient.SelectedRows[0].Cells[10].Value.ToString();
            maskTxtCEP.Text = dgvClient.SelectedRows[0].Cells[11].Value.ToString();
            string pessoa = dgvClient.SelectedRows[0].Cells[13].Value.ToString();
            switch (pessoa)
            {
                case "F":
                    cbxPessoa.SelectedIndex = 0;
                    break;
                case "J":
                    cbxPessoa.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
            //if (pessoa == "F")
            //{
                
            //}
            //else
            //{
            //    cbxPessoa.SelectedIndex = 1;
            //}
            maskTxtTel.Text = dgvClient.SelectedRows[0].Cells[14].Value.ToString();

            string valor = dgvClient.SelectedRows[0].Cells[12].Value.ToString();
            //MessageBox.Show(valor);

            if (valor == "True")
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }
        }

        private void dgvClient_DoubleClick(object sender, EventArgs e)
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
    }
}
