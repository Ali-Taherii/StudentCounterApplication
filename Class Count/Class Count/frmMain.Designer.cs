namespace Class_Count
{
    partial class frmMain
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
            this.grpDetials = new System.Windows.Forms.GroupBox();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.txtSessions = new System.Windows.Forms.TextBox();
            this.lblSessions = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.grpDetials.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 16;
            this.studentList.Location = new System.Drawing.Point(34, 52);
            this.studentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(173, 148);
            this.studentList.TabIndex = 0;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(31, 31);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(59, 16);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(34, 209);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(84, 27);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Enabled = false;
            this.btnRemoveStudent.Location = new System.Drawing.Point(122, 209);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(84, 27);
            this.btnRemoveStudent.TabIndex = 3;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // grpDetials
            // 
            this.grpDetials.Controls.Add(this.btnDecrease);
            this.grpDetials.Controls.Add(this.btnIncrease);
            this.grpDetials.Controls.Add(this.txtSessions);
            this.grpDetials.Controls.Add(this.lblSessions);
            this.grpDetials.Controls.Add(this.btnChange);
            this.grpDetials.Controls.Add(this.txtPayment);
            this.grpDetials.Controls.Add(this.lblPayment);
            this.grpDetials.Location = new System.Drawing.Point(225, 52);
            this.grpDetials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetials.Name = "grpDetials";
            this.grpDetials.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetials.Size = new System.Drawing.Size(347, 147);
            this.grpDetials.TabIndex = 4;
            this.grpDetials.TabStop = false;
            this.grpDetials.Text = "Details";
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(282, 90);
            this.btnDecrease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(43, 26);
            this.btnDecrease.TabIndex = 6;
            this.btnDecrease.Text = "-";
            this.btnDecrease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(235, 90);
            this.btnIncrease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(43, 26);
            this.btnIncrease.TabIndex = 5;
            this.btnIncrease.Text = "+";
            this.btnIncrease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // txtSessions
            // 
            this.txtSessions.Location = new System.Drawing.Point(115, 89);
            this.txtSessions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSessions.Name = "txtSessions";
            this.txtSessions.Size = new System.Drawing.Size(107, 22);
            this.txtSessions.TabIndex = 4;
            this.txtSessions.Text = "0";
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(15, 83);
            this.lblSessions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(75, 32);
            this.lblSessions.TabIndex = 3;
            this.lblSessions.Text = "Remaining \r\nSessions";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(248, 27);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(77, 26);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(115, 30);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(123, 22);
            this.txtPayment.TabIndex = 1;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(15, 32);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(88, 16);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Last Payment";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 251);
            this.Controls.Add(this.grpDetials);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.studentList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Students\' class count";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDetials.ResumeLayout(false);
            this.grpDetials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.GroupBox grpDetials;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.TextBox txtSessions;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnDecrease;
    }
}

