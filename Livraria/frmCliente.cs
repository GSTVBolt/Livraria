﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            lblCodigo.Visible = true;
            lblCod.Visible = true;

            btnAlterar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;

            txtNome.Enabled = true;
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

            }
        }
    }
}
