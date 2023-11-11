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
        private readonly StudentDatabase studentDB;
        public frmMain()
        {
            InitializeComponent();
            studentDB = new StudentDatabase();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.DataBind();
        }

        private void DataBind()
        {
            var students = studentDB.GetAllStudents();
            studentList.Items.Clear();

            foreach (var student in students)
            {
                studentList.Items.Add($"{student.FirstName} {student.LastName}");
            }

            txtPayment.Text = string.Empty;
            txtSessions.Text = string.Empty;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            // Create the student to be updated
            int selectedID = studentDB.findStudentId(studentList.Text);
            Student selectedStudent = studentDB.findStudent(selectedID);
            try
            {
                int sessions = Convert.ToInt32(txtSessions.Text);
                if (sessions > 0)
                    sessions--;
                txtSessions.Text = sessions.ToString();
                selectedStudent.Sessions = sessions;
                studentDB.UpdateStudent(selectedID, selectedStudent);
                studentDB.UpdateStudent(selectedID, selectedStudent);

            }
            catch
            {
                MessageBox.Show("The format is not correct");
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            // Create the student to be updated
            int selectedID = studentDB.findStudentId(studentList.Text);
            Student selectedStudent = studentDB.findStudent(selectedID);
            try
            {
                int sessions = Convert.ToInt32(txtSessions.Text);
                sessions++;
                txtSessions.Text = sessions.ToString();
                selectedStudent.Sessions = sessions;
                studentDB.UpdateStudent(selectedID, selectedStudent);

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

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveStudent.Enabled = true;

            int selectedID = studentDB.findStudentId(studentList.Text);
            Student selectedStudent = studentDB.findStudent(selectedID);

            if (selectedStudent != null)
            {
                txtPayment.Text = selectedStudent.Payment.ToString("yy / MMM / dd");
                txtSessions.Text = selectedStudent.Sessions.ToString();
            }

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            string stu = studentList.Text;
            if (studentDB.findStudentId(stu) != 0)
            {
                studentDB.DeleteStudent(studentDB.findStudentId(stu));
                DataBind();
            }
        }
    }
}

