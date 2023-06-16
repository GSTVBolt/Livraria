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

namespace Livraria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string usuario;
        public static string codUsuario;

        // Esbalecendo conexao com o bdd sql server

        SqlConnection cn = new SqlConnection(@"Data Source=./;Initial Catalog=db_Livraria;User Id=sa;Password=C#&&JS");

        SqlCommand cmd = new SqlCommand();

        //SqlDataReader dt;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos login e senha!", 
                                "Atenção !!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd.CommandText = "select * from tbl_atendente where ds_Login = ('" + txtLogin.Text + "') " +
                                      "and ds_Senha = ('"+ txtSenha.Text +"') and ds_status = 1";
                    cmd.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();

                    da.Fill(dtt);

                    //dt = cmd.ExecuteReader();

                    if (dtt.Rows.Count > 0) // a contagem de linhas no datable é maior que zero?
                    {
                        codUsuario = dtt.Rows[0]["cd_Atendente"].ToString();
                        usuario = dtt.Rows[0]["ds_Login"].ToString();
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", 
                                "Ocorreu um erro !!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();

                        txtLogin.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usuário nao encontrado" + ex.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
