using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
                if (Convert.ToInt32(txtSessions.Text) > 0)
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
            frmStudentDetails.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Create an instance of the StudentDatabase class
            using (StudentDatabase studentDB = new StudentDatabase())
            {
                // Retrieve a list of all students from the database
                var students = studentDB.GetAllStudents();

                // Clear the ListBox
                studentList.Items.Clear();

                // Populate the ListBox with student names
                foreach (var student in students)
                {
                    studentList.Items.Add($"{student.FirstName} {student.LastName}");
                }
            }
        }
    }
}

