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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblUni = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnDalykai = new System.Windows.Forms.Button();
            this.btnStudentai = new System.Windows.Forms.Button();
            this.btnDestotojai = new System.Windows.Forms.Button();
            this.btnFakultetai = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cmbY = new System.Windows.Forms.ComboBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.cmbX = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
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
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
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
            this.lblUni.Location = new System.Drawing.Point(191, 4);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(366, 51);
            this.lblUni.TabIndex = 1;
            this.lblUni.Text = "UNIVERSITETAS";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
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
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(0, 221);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(134, 27);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Redaguoti";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            // btnStatistika
            // 
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(0, 115);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(134, 36);
            this.btnStatistika.TabIndex = 0;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnDalykai
            // 
            this.btnDalykai.FlatAppearance.BorderSize = 0;
            this.btnDalykai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnDalykai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnDalykai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalykai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalykai.Location = new System.Drawing.Point(0, 86);
            this.btnDalykai.Name = "btnDalykai";
            this.btnDalykai.Size = new System.Drawing.Size(134, 36);
            this.btnDalykai.TabIndex = 0;
            this.btnDalykai.Text = "Dalykai";
            this.btnDalykai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDalykai.UseVisualStyleBackColor = true;
            this.btnDalykai.Click += new System.EventHandler(this.btnDalykai_Click);
            // 
            // btnStudentai
            // 
            this.btnStudentai.FlatAppearance.BorderSize = 0;
            this.btnStudentai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnStudentai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnStudentai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentai.Location = new System.Drawing.Point(0, 57);
            this.btnStudentai.Name = "btnStudentai";
            this.btnStudentai.Size = new System.Drawing.Size(134, 36);
            this.btnStudentai.TabIndex = 0;
            this.btnStudentai.Text = "Studentai";
            this.btnStudentai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentai.UseVisualStyleBackColor = true;
            this.btnStudentai.Click += new System.EventHandler(this.btnStudentai_Click);
            // 
            // btnDestotojai
            // 
            this.btnDestotojai.FlatAppearance.BorderSize = 0;
            this.btnDestotojai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnDestotojai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnDestotojai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestotojai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestotojai.Location = new System.Drawing.Point(0, 28);
            this.btnDestotojai.Name = "btnDestotojai";
            this.btnDestotojai.Size = new System.Drawing.Size(134, 36);
            this.btnDestotojai.TabIndex = 0;
            this.btnDestotojai.Text = "Dėstytojai";
            this.btnDestotojai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestotojai.UseVisualStyleBackColor = true;
            this.btnDestotojai.Click += new System.EventHandler(this.btnDestotojai_Click);
            // 
            // btnFakultetai
            // 
            this.btnFakultetai.FlatAppearance.BorderSize = 0;
            this.btnFakultetai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnFakultetai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnFakultetai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFakultetai.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFakultetai.Location = new System.Drawing.Point(0, -1);
            this.btnFakultetai.Name = "btnFakultetai";
            this.btnFakultetai.Size = new System.Drawing.Size(134, 36);
            this.btnFakultetai.TabIndex = 0;
            this.btnFakultetai.Text = "Fakultetai";
            this.btnFakultetai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFakultetai.UseVisualStyleBackColor = true;
            this.btnFakultetai.Click += new System.EventHandler(this.btnFakultetai_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.pnlCenter.Controls.Add(this.cmbY);
            this.pnlCenter.Controls.Add(this.lblY);
            this.pnlCenter.Controls.Add(this.lblX);
            this.pnlCenter.Controls.Add(this.cmbX);
            this.pnlCenter.Controls.Add(this.chart);
            this.pnlCenter.Controls.Add(this.dataGrid);
            this.pnlCenter.Location = new System.Drawing.Point(153, 52);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(571, 386);
            this.pnlCenter.TabIndex = 3;
            // 
            // cmbY
            // 
            this.cmbY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.cmbY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbY.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbY.FormattingEnabled = true;
            this.cmbY.Items.AddRange(new object[] {
            "Dalykas",
            "Dėstytojas",
            "Fakultetas",
            "Studentas"});
            this.cmbY.Location = new System.Drawing.Point(239, 5);
            this.cmbY.Name = "cmbY";
            this.cmbY.Size = new System.Drawing.Size(121, 23);
            this.cmbY.TabIndex = 4;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblY.Location = new System.Drawing.Point(187, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(52, 16);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "X axis:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblX.Location = new System.Drawing.Point(8, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(52, 16);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "Y axis:";
            // 
            // cmbX
            // 
            this.cmbX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.cmbX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbX.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbX.FormattingEnabled = true;
            this.cmbX.Items.AddRange(new object[] {
            "Dalykas",
            "Dėstytojas",
            "Studentas"});
            this.cmbX.Location = new System.Drawing.Point(60, 5);
            this.cmbX.Name = "cmbX";
            this.cmbX.Size = new System.Drawing.Size(121, 23);
            this.cmbX.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(4, 28);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(564, 355);
            this.chart.TabIndex = 1;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(564, 379);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.AutoGenerateColumns = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
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
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            if(VUcounter++==10)
            {
                VUcounter = 0;
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.vu.lt"));
            }
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
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ComboBox cmbX;
        private System.Windows.Forms.ComboBox cmbY;
        private System.Windows.Forms.Label lblY;
    }
}

