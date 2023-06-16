using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            principal1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUserLog.Text = Login.usuario;
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmFuncionario1.BringToFront();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente1.BringToFront();
        }
    }
}
