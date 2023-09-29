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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.grpDetials.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 24;
            this.studentList.Location = new System.Drawing.Point(47, 78);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(236, 220);
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
            this.btnAddStudent.Location = new System.Drawing.Point(47, 313);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(115, 41);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Enabled = false;
            this.btnRemoveStudent.Location = new System.Drawing.Point(168, 313);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(115, 41);
            this.btnRemoveStudent.TabIndex = 3;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // grpDetials
            // 
            this.grpDetials.Controls.Add(this.btnDecrease);
            this.grpDetials.Controls.Add(this.btnIncrease);
            this.grpDetials.Controls.Add(this.txtSessions);
            this.grpDetials.Controls.Add(this.lblSessions);
            this.grpDetials.Controls.Add(this.button1);
            this.grpDetials.Controls.Add(this.txtPayment);
            this.grpDetials.Controls.Add(this.lblPayment);
            this.grpDetials.Enabled = false;
            this.grpDetials.Location = new System.Drawing.Point(309, 78);
            this.grpDetials.Name = "grpDetials";
            this.grpDetials.Size = new System.Drawing.Size(477, 220);
            this.grpDetials.TabIndex = 4;
            this.grpDetials.TabStop = false;
            this.grpDetials.Text = "Details";
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(388, 135);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(59, 29);
            this.btnDecrease.TabIndex = 6;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(323, 135);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(59, 29);
            this.btnIncrease.TabIndex = 5;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // txtSessions
            // 
            this.txtSessions.Location = new System.Drawing.Point(158, 134);
            this.txtSessions.Name = "txtSessions";
            this.txtSessions.Size = new System.Drawing.Size(146, 29);
            this.txtSessions.TabIndex = 4;
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(21, 124);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(109, 50);
            this.lblSessions.TabIndex = 3;
            this.lblSessions.Text = "Remaining \r\nSessions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(158, 45);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(168, 29);
            this.txtPayment.TabIndex = 1;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(21, 48);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(131, 25);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Last Payment";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 376);
            this.Controls.Add(this.grpDetials);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.studentList);
            this.Name = "frmMain";
            this.Text = "Students\' class count";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnDecrease;
    }
}

