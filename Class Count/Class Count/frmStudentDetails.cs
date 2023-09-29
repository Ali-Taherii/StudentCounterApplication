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
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length != 0 && txtLastname.Text.Length != 0 && numSessions.Value > 0) 
            {
                Student student = new Student()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    Payment = dateTimePicker1.Value,
                    Sessions = Convert.ToInt32(numSessions.Value)
                };
            }
        }
    }
}
