using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                // Generate a unique ID
                Guid uniqueId = Guid.NewGuid();

                // Convert the Guid to an integer (32 bits)
                int uniqueInt = uniqueId.GetHashCode();

                // Ensure the integer is non-negative
                uniqueInt = Math.Abs(uniqueInt);

                // Create a Student object with the entered data
                Student student = new Student()
                {
                    Id = uniqueInt,
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    Payment = dateTimePicker1.Value,
                    Sessions = Convert.ToInt32(numSessions.Value)
                };

                // Create an instance of the StudentDatabase
                using (StudentDatabase studentDB = new StudentDatabase())
                {
                    // Insert the new student into the database
                    studentDB.InsertStudent(student);
                };

                // Optionally, you can clear the input fields or display a confirmation message.
                txtFirstname.Clear();
                txtLastname.Clear();
                numSessions.Value = 0;
                dateTimePicker1.Value = DateTime.Now;

                MessageBox.Show("Student registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
