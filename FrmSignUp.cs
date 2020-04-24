using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200424_YuGiOh_PoC_Lejkic_Edition
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtEm_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtEm.Text == "Email")
            {
                txtEm.Text = "";
                txtEm.ForeColor = Color.Black;
            }
        }

        private void txtEm_Leave(object sender, EventArgs e)
        {
            if(txtEm.Text == "")
            {
                txtEm.Text = "Email";
                txtEm.ForeColor = Color.Gray;
            }
        }

        private void txtConEm_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtConEm.Text == "Confirm Email")
            {
                txtConEm.Text = "";
                txtConEm.ForeColor = Color.Black;
            }
        }

        private void txtConEm_Leave(object sender, EventArgs e)
        {
            if (txtConEm.Text == "")
            {
                txtConEm.Text = "Confirm Email";
                txtConEm.ForeColor = Color.Gray;
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtConPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConPass.Text == "Confirm Password")
            {
                txtConPass.Text = "";
                txtConPass.ForeColor = Color.Black;
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (txtConPass.Text == "")
            {
                txtConPass.Text = "Confirm Password";
                txtConPass.ForeColor = Color.Gray;
            }
        }
    }
}
