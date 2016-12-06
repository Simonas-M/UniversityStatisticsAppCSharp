using System.Drawing;

namespace UniversitySQL
{
    partial class MainWindow
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblUni = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnDalykai = new System.Windows.Forms.Button();
            this.btnStudentai = new System.Windows.Forms.Button();
            this.btnDestotojai = new System.Windows.Forms.Button();
            this.btnFakultetai = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(724, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(701, -3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Font = new System.Drawing.Font("Trajan Pro", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUni.Location = new System.Drawing.Point(191, -2);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(366, 51);
            this.lblUni.TabIndex = 1;
            this.lblUni.Text = "UNIVERSITETAS";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnAddNew);
            this.pnlRight.Controls.Add(this.pictureBox1);
            this.pnlRight.Controls.Add(this.btnStatistika);
            this.pnlRight.Controls.Add(this.btnDalykai);
            this.pnlRight.Controls.Add(this.btnStudentai);
            this.pnlRight.Controls.Add(this.btnDestotojai);
            this.pnlRight.Controls.Add(this.btnFakultetai);
            this.pnlRight.Location = new System.Drawing.Point(12, 52);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(134, 386);
            this.pnlRight.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(0, 221);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(134, 27);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Pridėti Naują";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnStatistika
            // 
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(0, 120);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(134, 23);
            this.btnStatistika.TabIndex = 0;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.UseVisualStyleBackColor = true;
            // 
            // btnDalykai
            // 
            this.btnDalykai.FlatAppearance.BorderSize = 0;
            this.btnDalykai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalykai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalykai.Location = new System.Drawing.Point(0, 91);
            this.btnDalykai.Name = "btnDalykai";
            this.btnDalykai.Size = new System.Drawing.Size(134, 23);
            this.btnDalykai.TabIndex = 0;
            this.btnDalykai.Text = "Dalykai";
            this.btnDalykai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDalykai.UseVisualStyleBackColor = true;
            // 
            // btnStudentai
            // 
            this.btnStudentai.FlatAppearance.BorderSize = 0;
            this.btnStudentai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentai.Location = new System.Drawing.Point(0, 62);
            this.btnStudentai.Name = "btnStudentai";
            this.btnStudentai.Size = new System.Drawing.Size(134, 23);
            this.btnStudentai.TabIndex = 0;
            this.btnStudentai.Text = "Studentai";
            this.btnStudentai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentai.UseVisualStyleBackColor = true;
            // 
            // btnDestotojai
            // 
            this.btnDestotojai.FlatAppearance.BorderSize = 0;
            this.btnDestotojai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestotojai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestotojai.Location = new System.Drawing.Point(0, 33);
            this.btnDestotojai.Name = "btnDestotojai";
            this.btnDestotojai.Size = new System.Drawing.Size(134, 23);
            this.btnDestotojai.TabIndex = 0;
            this.btnDestotojai.Text = "Dėstytojai";
            this.btnDestotojai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestotojai.UseVisualStyleBackColor = true;
            // 
            // btnFakultetai
            // 
            this.btnFakultetai.FlatAppearance.BorderSize = 0;
            this.btnFakultetai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFakultetai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFakultetai.Location = new System.Drawing.Point(0, 4);
            this.btnFakultetai.Name = "btnFakultetai";
            this.btnFakultetai.Size = new System.Drawing.Size(134, 23);
            this.btnFakultetai.TabIndex = 0;
            this.btnFakultetai.Text = "Fakultetai";
            this.btnFakultetai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFakultetai.UseVisualStyleBackColor = true;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Location = new System.Drawing.Point(153, 52);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(571, 386);
            this.pnlCenter.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversitySQL.Properties.Resources.vu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(746, 450);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnDalykai;
        private System.Windows.Forms.Button btnStudentai;
        private System.Windows.Forms.Button btnDestotojai;
        private System.Windows.Forms.Button btnFakultetai;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

