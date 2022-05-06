using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email;

            DataTable dtTable = new DataTable();
            email = txtEmail.Text;
            frmPrincipal login = new frmPrincipal();
            login.email = txtEmail.Text;
            login.ShowDialog();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
