using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Count
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                txtSessions.Text = (Convert.ToInt32(txtSessions.Text) - 1).ToString();
            }
            catch
            {
                MessageBox.Show("The format is not correct");
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                txtSessions.Text = (Convert.ToInt32(txtSessions.Text) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("The format is not correct");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmStudentDetails frmStudentDetails = new frmStudentDetails();
        }

    }
}
