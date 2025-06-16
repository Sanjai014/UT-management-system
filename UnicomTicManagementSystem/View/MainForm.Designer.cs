namespace UnicomTicManagementSystem.View
{
    partial class MainForm
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
            this.Wlabel = new System.Windows.Forms.Label();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTimetables = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wlabel
            // 
            this.Wlabel.AutoSize = true;
            this.Wlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel.Location = new System.Drawing.Point(412, 25);
            this.Wlabel.Name = "Wlabel";
            this.Wlabel.Size = new System.Drawing.Size(240, 25);
            this.Wlabel.TabIndex = 0;
            this.Wlabel.Text = "Welcome, [User Role]";
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(35, 137);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(180, 23);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Manage Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(466, 524);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 38);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTimetables
            // 
            this.btnTimetables.Location = new System.Drawing.Point(966, 290);
            this.btnTimetables.Name = "btnTimetables";
            this.btnTimetables.Size = new System.Drawing.Size(179, 23);
            this.btnTimetables.TabIndex = 3;
            this.btnTimetables.Text = "Manage Timetable";
            this.btnTimetables.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Manage Exams";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(966, 124);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(179, 23);
            this.btnMarks.TabIndex = 5;
            this.btnMarks.Text = "Manage Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(466, 137);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(186, 23);
            this.btnSubject.TabIndex = 6;
            this.btnSubject.Text = "Manage Subjects";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(35, 290);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(180, 23);
            this.btnStudents.TabIndex = 7;
            this.btnStudents.Text = "Manage Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 656);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTimetables);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.Wlabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wlabel;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTimetables;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnStudents;
    }
}