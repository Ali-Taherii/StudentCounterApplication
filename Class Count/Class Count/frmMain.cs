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

        private void DataBind()
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
            this.DataBind();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.DataBind();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveStudent.Enabled = true;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            string stu = studentList.SelectedItem.ToString();

            using (StudentDatabase studentDatabase = new StudentDatabase())
            {
                foreach (Student student in studentDatabase.GetAllStudents())
                {
                    String fullName = student.FirstName + " " + student.LastName;
                    if (fullName == stu)
                    {
                        studentDatabase.DeleteStudent(student.Id); ;
                        DataBind();
                    }
                }
            }
            
        }
    }
}

