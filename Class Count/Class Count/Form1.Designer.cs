namespace Class_Count
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentList = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 24;
            this.studentList.Location = new System.Drawing.Point(47, 78);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(236, 388);
            this.studentList.TabIndex = 0;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(42, 46);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(90, 25);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(47, 472);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(115, 41);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Enabled = false;
            this.btnRemoveStudent.Location = new System.Drawing.Point(168, 472);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(115, 41);
            this.btnRemoveStudent.TabIndex = 3;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 596);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Students\' class count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}

