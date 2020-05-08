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
    public partial class FrmStartUp : Form
    {
        FrmLogIn frm = new FrmLogIn();
        public FrmStartUp()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
