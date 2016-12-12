namespace UniversitySQL
{
    partial class TaughtCoursesForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblErrorRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbAKLecturer = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblErrorUnregister = new System.Windows.Forms.Label();
            this.btnUnregister = new System.Windows.Forms.Button();
            this.cmbLecturerCourses = new System.Windows.Forms.ComboBox();
            this.cmbLecturerDelete = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(231, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 111);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblErrorRegister);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.cmbCourses);
            this.tabPage1.Controls.Add(this.cmbAKLecturer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 85);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registruoti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblErrorRegister
            // 
            this.lblErrorRegister.AutoSize = true;
            this.lblErrorRegister.Location = new System.Drawing.Point(3, 59);
            this.lblErrorRegister.Name = "lblErrorRegister";
            this.lblErrorRegister.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRegister.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(160, 59);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(74, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Registruoti";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(8, 33);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(226, 21);
            this.cmbCourses.TabIndex = 8;
            // 
            // cmbAKLecturer
            // 
            this.cmbAKLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAKLecturer.FormattingEnabled = true;
            this.cmbAKLecturer.Location = new System.Drawing.Point(8, 6);
            this.cmbAKLecturer.Name = "cmbAKLecturer";
            this.cmbAKLecturer.Size = new System.Drawing.Size(226, 21);
            this.cmbAKLecturer.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblErrorUnregister);
            this.tabPage2.Controls.Add(this.btnUnregister);
            this.tabPage2.Controls.Add(this.cmbLecturerCourses);
            this.tabPage2.Controls.Add(this.cmbLecturerDelete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 85);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Šalinti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblErrorUnregister
            // 
            this.lblErrorUnregister.AutoSize = true;
            this.lblErrorUnregister.Location = new System.Drawing.Point(8, 59);
            this.lblErrorUnregister.Name = "lblErrorUnregister";
            this.lblErrorUnregister.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUnregister.TabIndex = 14;
            // 
            // btnUnregister
            // 
            this.btnUnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUnregister.FlatAppearance.BorderSize = 0;
            this.btnUnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnregister.ForeColor = System.Drawing.Color.Black;
            this.btnUnregister.Location = new System.Drawing.Point(160, 59);
            this.btnUnregister.Name = "btnUnregister";
            this.btnUnregister.Size = new System.Drawing.Size(74, 23);
            this.btnUnregister.TabIndex = 12;
            this.btnUnregister.Text = "Šalinti";
            this.btnUnregister.UseVisualStyleBackColor = true;
            this.btnUnregister.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // cmbLecturerCourses
            // 
            this.cmbLecturerCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLecturerCourses.FormattingEnabled = true;
            this.cmbLecturerCourses.Location = new System.Drawing.Point(8, 33);
            this.cmbLecturerCourses.Name = "cmbLecturerCourses";
            this.cmbLecturerCourses.Size = new System.Drawing.Size(226, 21);
            this.cmbLecturerCourses.TabIndex = 11;
            // 
            // cmbLecturerDelete
            // 
            this.cmbLecturerDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLecturerDelete.FormattingEnabled = true;
            this.cmbLecturerDelete.Location = new System.Drawing.Point(8, 6);
            this.cmbLecturerDelete.Name = "cmbLecturerDelete";
            this.cmbLecturerDelete.Size = new System.Drawing.Size(226, 21);
            this.cmbLecturerDelete.TabIndex = 10;
            this.cmbLecturerDelete.SelectedIndexChanged += new System.EventHandler(this.cmbLecturerDelete_SelectedIndexChanged);
            // 
            // TaughtCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(251, 112);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaughtCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaughtCoursesForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblErrorRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbAKLecturer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUnregister;
        private System.Windows.Forms.ComboBox cmbLecturerCourses;
        private System.Windows.Forms.ComboBox cmbLecturerDelete;
        private System.Windows.Forms.Label lblErrorUnregister;
    }
}