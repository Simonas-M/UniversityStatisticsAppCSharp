using System;

namespace UniversitySQL
{
    partial class EditWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFakultetas = new System.Windows.Forms.TabPage();
            this.btnConfirmUpdateFakultetas = new System.Windows.Forms.Button();
            this.lblErrorFaculty = new System.Windows.Forms.Label();
            this.btnDeleteFakultetas = new System.Windows.Forms.Button();
            this.btnAddFakultetas = new System.Windows.Forms.Button();
            this.btnUpdateFakultetas = new System.Windows.Forms.Button();
            this.txtPhoneNrFakultetas = new System.Windows.Forms.TextBox();
            this.txtAddressFakultetas = new System.Windows.Forms.TextBox();
            this.txtTitleFakultetas = new System.Windows.Forms.TextBox();
            this.tabDalykas = new System.Windows.Forms.TabPage();
            this.cmbIDDalykas = new System.Windows.Forms.ComboBox();
            this.lblErrorCourse = new System.Windows.Forms.Label();
            this.btnDeleteDalykas = new System.Windows.Forms.Button();
            this.btnAddDalykas = new System.Windows.Forms.Button();
            this.btnConfirmUpdateDalykas = new System.Windows.Forms.Button();
            this.btnUpdateDalykas = new System.Windows.Forms.Button();
            this.txtCreditsDalykas = new System.Windows.Forms.TextBox();
            this.txtTitleDalykas = new System.Windows.Forms.TextBox();
            this.tabDestytojas = new System.Windows.Forms.TabPage();
            this.cmbDegreeDestytojas = new System.Windows.Forms.ComboBox();
            this.btnConfirmUpdateDestytojas = new System.Windows.Forms.Button();
            this.btnConfirmAddDestytojas = new System.Windows.Forms.Button();
            this.txtAKDestytojas = new System.Windows.Forms.TextBox();
            this.cmbFacultyDestytojas = new System.Windows.Forms.ComboBox();
            this.lblErrorLecturer = new System.Windows.Forms.Label();
            this.cmbAKDestytojas = new System.Windows.Forms.ComboBox();
            this.btnDeleteDestytojas = new System.Windows.Forms.Button();
            this.btnAddDestytojas = new System.Windows.Forms.Button();
            this.btnUpdateDestytojas = new System.Windows.Forms.Button();
            this.txtSurnameDestytojas = new System.Windows.Forms.TextBox();
            this.txtNameDestytojas = new System.Windows.Forms.TextBox();
            this.tabStudentas = new System.Windows.Forms.TabPage();
            this.txtLSPStudentas = new System.Windows.Forms.TextBox();
            this.btnConfirmUpdateStudentas = new System.Windows.Forms.Button();
            this.btnConfirmAddStudentas = new System.Windows.Forms.Button();
            this.lblErrorStudent = new System.Windows.Forms.Label();
            this.btnDeleteStudentas = new System.Windows.Forms.Button();
            this.btnUpdateStudentas = new System.Windows.Forms.Button();
            this.btnAddStudentas = new System.Windows.Forms.Button();
            this.cmbDegreeStudentas = new System.Windows.Forms.ComboBox();
            this.cmbLSPStudentas = new System.Windows.Forms.ComboBox();
            this.dtpBirthStudentas = new System.Windows.Forms.DateTimePicker();
            this.txtSurnameStudentas = new System.Windows.Forms.TextBox();
            this.txtNameStudentas = new System.Windows.Forms.TextBox();
            this.cmbFacultyStudentas = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabFakultetas.SuspendLayout();
            this.tabDalykas.SuspendLayout();
            this.tabDestytojas.SuspendLayout();
            this.tabStudentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFakultetas);
            this.tabControl1.Controls.Add(this.tabDalykas);
            this.tabControl1.Controls.Add(this.tabDestytojas);
            this.tabControl1.Controls.Add(this.tabStudentas);
            this.tabControl1.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFakultetas
            // 
            this.tabFakultetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabFakultetas.Controls.Add(this.btnConfirmUpdateFakultetas);
            this.tabFakultetas.Controls.Add(this.lblErrorFaculty);
            this.tabFakultetas.Controls.Add(this.btnDeleteFakultetas);
            this.tabFakultetas.Controls.Add(this.btnAddFakultetas);
            this.tabFakultetas.Controls.Add(this.btnUpdateFakultetas);
            this.tabFakultetas.Controls.Add(this.txtPhoneNrFakultetas);
            this.tabFakultetas.Controls.Add(this.txtAddressFakultetas);
            this.tabFakultetas.Controls.Add(this.txtTitleFakultetas);
            this.tabFakultetas.Location = new System.Drawing.Point(4, 25);
            this.tabFakultetas.Name = "tabFakultetas";
            this.tabFakultetas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFakultetas.Size = new System.Drawing.Size(394, 276);
            this.tabFakultetas.TabIndex = 0;
            this.tabFakultetas.Text = "Fakultetas";
            // 
            // btnConfirmUpdateFakultetas
            // 
            this.btnConfirmUpdateFakultetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmUpdateFakultetas.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdateFakultetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdateFakultetas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmUpdateFakultetas.Location = new System.Drawing.Point(244, 48);
            this.btnConfirmUpdateFakultetas.Name = "btnConfirmUpdateFakultetas";
            this.btnConfirmUpdateFakultetas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmUpdateFakultetas.TabIndex = 5;
            this.btnConfirmUpdateFakultetas.UseVisualStyleBackColor = true;
            this.btnConfirmUpdateFakultetas.Click += new System.EventHandler(this.btnConfirmUpdateFakultetas_Click);
            // 
            // lblErrorFaculty
            // 
            this.lblErrorFaculty.AutoSize = true;
            this.lblErrorFaculty.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFaculty.Location = new System.Drawing.Point(12, 89);
            this.lblErrorFaculty.Name = "lblErrorFaculty";
            this.lblErrorFaculty.Size = new System.Drawing.Size(0, 15);
            this.lblErrorFaculty.TabIndex = 4;
            // 
            // btnDeleteFakultetas
            // 
            this.btnDeleteFakultetas.BackColor = System.Drawing.Color.Red;
            this.btnDeleteFakultetas.FlatAppearance.BorderSize = 0;
            this.btnDeleteFakultetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFakultetas.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFakultetas.Location = new System.Drawing.Point(244, 89);
            this.btnDeleteFakultetas.Name = "btnDeleteFakultetas";
            this.btnDeleteFakultetas.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteFakultetas.TabIndex = 3;
            this.btnDeleteFakultetas.Text = "Ištrinti";
            this.btnDeleteFakultetas.UseVisualStyleBackColor = true;
            this.btnDeleteFakultetas.Click += new System.EventHandler(this.btnDeleteFakultetas_Click);
            // 
            // btnAddFakultetas
            // 
            this.btnAddFakultetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddFakultetas.FlatAppearance.BorderSize = 0;
            this.btnAddFakultetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFakultetas.ForeColor = System.Drawing.Color.Black;
            this.btnAddFakultetas.Location = new System.Drawing.Point(244, 7);
            this.btnAddFakultetas.Name = "btnAddFakultetas";
            this.btnAddFakultetas.Size = new System.Drawing.Size(123, 36);
            this.btnAddFakultetas.TabIndex = 3;
            this.btnAddFakultetas.Text = "Įvesti";
            this.btnAddFakultetas.UseVisualStyleBackColor = true;
            this.btnAddFakultetas.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdateFakultetas
            // 
            this.btnUpdateFakultetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUpdateFakultetas.FlatAppearance.BorderSize = 0;
            this.btnUpdateFakultetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFakultetas.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateFakultetas.Location = new System.Drawing.Point(244, 48);
            this.btnUpdateFakultetas.Name = "btnUpdateFakultetas";
            this.btnUpdateFakultetas.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateFakultetas.TabIndex = 3;
            this.btnUpdateFakultetas.Text = "Pakeisti";
            this.btnUpdateFakultetas.UseVisualStyleBackColor = true;
            this.btnUpdateFakultetas.Click += new System.EventHandler(this.btnUpdateFakultetas_Click);
            // 
            // txtPhoneNrFakultetas
            // 
            this.txtPhoneNrFakultetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNrFakultetas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNrFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNrFakultetas.Location = new System.Drawing.Point(12, 63);
            this.txtPhoneNrFakultetas.Name = "txtPhoneNrFakultetas";
            this.txtPhoneNrFakultetas.Size = new System.Drawing.Size(226, 20);
            this.txtPhoneNrFakultetas.TabIndex = 2;
            this.txtPhoneNrFakultetas.Text = "Telefono Nr.";
            // 
            // txtAddressFakultetas
            // 
            this.txtAddressFakultetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressFakultetas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtAddressFakultetas.Location = new System.Drawing.Point(12, 35);
            this.txtAddressFakultetas.Name = "txtAddressFakultetas";
            this.txtAddressFakultetas.Size = new System.Drawing.Size(226, 20);
            this.txtAddressFakultetas.TabIndex = 1;
            this.txtAddressFakultetas.Text = "Adresas";
            // 
            // txtTitleFakultetas
            // 
            this.txtTitleFakultetas.BackColor = System.Drawing.Color.PaleGreen;
            this.txtTitleFakultetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleFakultetas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtTitleFakultetas.Location = new System.Drawing.Point(12, 7);
            this.txtTitleFakultetas.Name = "txtTitleFakultetas";
            this.txtTitleFakultetas.Size = new System.Drawing.Size(226, 20);
            this.txtTitleFakultetas.TabIndex = 0;
            this.txtTitleFakultetas.Text = "Pavadinimas";
            // 
            // tabDalykas
            // 
            this.tabDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabDalykas.Controls.Add(this.cmbIDDalykas);
            this.tabDalykas.Controls.Add(this.lblErrorCourse);
            this.tabDalykas.Controls.Add(this.btnDeleteDalykas);
            this.tabDalykas.Controls.Add(this.btnAddDalykas);
            this.tabDalykas.Controls.Add(this.btnConfirmUpdateDalykas);
            this.tabDalykas.Controls.Add(this.btnUpdateDalykas);
            this.tabDalykas.Controls.Add(this.txtCreditsDalykas);
            this.tabDalykas.Controls.Add(this.txtTitleDalykas);
            this.tabDalykas.Location = new System.Drawing.Point(4, 25);
            this.tabDalykas.Name = "tabDalykas";
            this.tabDalykas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDalykas.Size = new System.Drawing.Size(394, 276);
            this.tabDalykas.TabIndex = 1;
            this.tabDalykas.Text = "Dalykas";
            // 
            // cmbIDDalykas
            // 
            this.cmbIDDalykas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIDDalykas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbIDDalykas.FormattingEnabled = true;
            this.cmbIDDalykas.Location = new System.Drawing.Point(12, 6);
            this.cmbIDDalykas.Name = "cmbIDDalykas";
            this.cmbIDDalykas.Size = new System.Drawing.Size(226, 21);
            this.cmbIDDalykas.TabIndex = 10;
            // 
            // lblErrorCourse
            // 
            this.lblErrorCourse.AutoSize = true;
            this.lblErrorCourse.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCourse.Location = new System.Drawing.Point(12, 89);
            this.lblErrorCourse.Name = "lblErrorCourse";
            this.lblErrorCourse.Size = new System.Drawing.Size(0, 15);
            this.lblErrorCourse.TabIndex = 9;
            // 
            // btnDeleteDalykas
            // 
            this.btnDeleteDalykas.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDalykas.FlatAppearance.BorderSize = 0;
            this.btnDeleteDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDalykas.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteDalykas.Location = new System.Drawing.Point(244, 89);
            this.btnDeleteDalykas.Name = "btnDeleteDalykas";
            this.btnDeleteDalykas.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteDalykas.TabIndex = 6;
            this.btnDeleteDalykas.Text = "Ištrinti";
            this.btnDeleteDalykas.UseVisualStyleBackColor = false;
            this.btnDeleteDalykas.Click += new System.EventHandler(this.btnDeleteDalykas_Click);
            // 
            // btnAddDalykas
            // 
            this.btnAddDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddDalykas.FlatAppearance.BorderSize = 0;
            this.btnAddDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDalykas.ForeColor = System.Drawing.Color.Black;
            this.btnAddDalykas.Location = new System.Drawing.Point(244, 7);
            this.btnAddDalykas.Name = "btnAddDalykas";
            this.btnAddDalykas.Size = new System.Drawing.Size(123, 36);
            this.btnAddDalykas.TabIndex = 7;
            this.btnAddDalykas.Text = "Įvesti";
            this.btnAddDalykas.UseVisualStyleBackColor = true;
            this.btnAddDalykas.Click += new System.EventHandler(this.btnAddDalykas_Click);
            // 
            // btnConfirmUpdateDalykas
            // 
            this.btnConfirmUpdateDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmUpdateDalykas.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdateDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdateDalykas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmUpdateDalykas.Location = new System.Drawing.Point(244, 47);
            this.btnConfirmUpdateDalykas.Name = "btnConfirmUpdateDalykas";
            this.btnConfirmUpdateDalykas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmUpdateDalykas.TabIndex = 8;
            this.btnConfirmUpdateDalykas.UseVisualStyleBackColor = true;
            this.btnConfirmUpdateDalykas.Click += new System.EventHandler(this.btnConfirmUpdateDalykas_Click);
            // 
            // btnUpdateDalykas
            // 
            this.btnUpdateDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUpdateDalykas.FlatAppearance.BorderSize = 0;
            this.btnUpdateDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDalykas.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDalykas.Location = new System.Drawing.Point(244, 47);
            this.btnUpdateDalykas.Name = "btnUpdateDalykas";
            this.btnUpdateDalykas.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateDalykas.TabIndex = 8;
            this.btnUpdateDalykas.Text = "Pakeisti";
            this.btnUpdateDalykas.UseVisualStyleBackColor = true;
            this.btnUpdateDalykas.Click += new System.EventHandler(this.btnUpdateDalykas_Click);
            // 
            // txtCreditsDalykas
            // 
            this.txtCreditsDalykas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditsDalykas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditsDalykas.ForeColor = System.Drawing.Color.Gray;
            this.txtCreditsDalykas.Location = new System.Drawing.Point(12, 63);
            this.txtCreditsDalykas.Name = "txtCreditsDalykas";
            this.txtCreditsDalykas.Size = new System.Drawing.Size(226, 20);
            this.txtCreditsDalykas.TabIndex = 5;
            this.txtCreditsDalykas.Text = "Kreditu sk.";
            // 
            // txtTitleDalykas
            // 
            this.txtTitleDalykas.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitleDalykas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleDalykas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleDalykas.ForeColor = System.Drawing.Color.Gray;
            this.txtTitleDalykas.Location = new System.Drawing.Point(12, 35);
            this.txtTitleDalykas.Name = "txtTitleDalykas";
            this.txtTitleDalykas.Size = new System.Drawing.Size(226, 20);
            this.txtTitleDalykas.TabIndex = 4;
            this.txtTitleDalykas.Text = "Pavadinimas";
            // 
            // tabDestytojas
            // 
            this.tabDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabDestytojas.Controls.Add(this.cmbDegreeDestytojas);
            this.tabDestytojas.Controls.Add(this.btnConfirmUpdateDestytojas);
            this.tabDestytojas.Controls.Add(this.btnConfirmAddDestytojas);
            this.tabDestytojas.Controls.Add(this.txtAKDestytojas);
            this.tabDestytojas.Controls.Add(this.cmbFacultyDestytojas);
            this.tabDestytojas.Controls.Add(this.lblErrorLecturer);
            this.tabDestytojas.Controls.Add(this.cmbAKDestytojas);
            this.tabDestytojas.Controls.Add(this.btnDeleteDestytojas);
            this.tabDestytojas.Controls.Add(this.btnAddDestytojas);
            this.tabDestytojas.Controls.Add(this.btnUpdateDestytojas);
            this.tabDestytojas.Controls.Add(this.txtSurnameDestytojas);
            this.tabDestytojas.Controls.Add(this.txtNameDestytojas);
            this.tabDestytojas.Location = new System.Drawing.Point(4, 25);
            this.tabDestytojas.Name = "tabDestytojas";
            this.tabDestytojas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestytojas.Size = new System.Drawing.Size(394, 276);
            this.tabDestytojas.TabIndex = 2;
            this.tabDestytojas.Text = "Dėstytojas";
            // 
            // cmbDegreeDestytojas
            // 
            this.cmbDegreeDestytojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDegreeDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDegreeDestytojas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbDegreeDestytojas.FormattingEnabled = true;
            this.cmbDegreeDestytojas.Items.AddRange(new object[] {
            "Docentas",
            "Lektorius",
            "Asistentas"});
            this.cmbDegreeDestytojas.Location = new System.Drawing.Point(12, 115);
            this.cmbDegreeDestytojas.Name = "cmbDegreeDestytojas";
            this.cmbDegreeDestytojas.Size = new System.Drawing.Size(226, 21);
            this.cmbDegreeDestytojas.TabIndex = 23;
            // 
            // btnConfirmUpdateDestytojas
            // 
            this.btnConfirmUpdateDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmUpdateDestytojas.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdateDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdateDestytojas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmUpdateDestytojas.Location = new System.Drawing.Point(244, 47);
            this.btnConfirmUpdateDestytojas.Name = "btnConfirmUpdateDestytojas";
            this.btnConfirmUpdateDestytojas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmUpdateDestytojas.TabIndex = 18;
            this.btnConfirmUpdateDestytojas.UseVisualStyleBackColor = true;
            this.btnConfirmUpdateDestytojas.Click += new System.EventHandler(this.btnConfirmUpdateDestytojas_Click);
            // 
            // btnConfirmAddDestytojas
            // 
            this.btnConfirmAddDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmAddDestytojas.FlatAppearance.BorderSize = 0;
            this.btnConfirmAddDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAddDestytojas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmAddDestytojas.Location = new System.Drawing.Point(244, 7);
            this.btnConfirmAddDestytojas.Name = "btnConfirmAddDestytojas";
            this.btnConfirmAddDestytojas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmAddDestytojas.TabIndex = 17;
            this.btnConfirmAddDestytojas.UseVisualStyleBackColor = true;
            this.btnConfirmAddDestytojas.Click += new System.EventHandler(this.btnConfirmAddDestytojas_Click);
            // 
            // txtAKDestytojas
            // 
            this.txtAKDestytojas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAKDestytojas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtAKDestytojas.ForeColor = System.Drawing.Color.Gray;
            this.txtAKDestytojas.Location = new System.Drawing.Point(12, 6);
            this.txtAKDestytojas.Name = "txtAKDestytojas";
            this.txtAKDestytojas.Size = new System.Drawing.Size(226, 20);
            this.txtAKDestytojas.TabIndex = 16;
            this.txtAKDestytojas.Text = "AK";
            // 
            // cmbFacultyDestytojas
            // 
            this.cmbFacultyDestytojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacultyDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFacultyDestytojas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbFacultyDestytojas.FormattingEnabled = true;
            this.cmbFacultyDestytojas.Location = new System.Drawing.Point(12, 34);
            this.cmbFacultyDestytojas.Name = "cmbFacultyDestytojas";
            this.cmbFacultyDestytojas.Size = new System.Drawing.Size(226, 21);
            this.cmbFacultyDestytojas.TabIndex = 14;
            // 
            // lblErrorLecturer
            // 
            this.lblErrorLecturer.AutoSize = true;
            this.lblErrorLecturer.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLecturer.Location = new System.Drawing.Point(12, 141);
            this.lblErrorLecturer.Name = "lblErrorLecturer";
            this.lblErrorLecturer.Size = new System.Drawing.Size(0, 15);
            this.lblErrorLecturer.TabIndex = 13;
            // 
            // cmbAKDestytojas
            // 
            this.cmbAKDestytojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAKDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAKDestytojas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbAKDestytojas.FormattingEnabled = true;
            this.cmbAKDestytojas.Location = new System.Drawing.Point(12, 6);
            this.cmbAKDestytojas.Name = "cmbAKDestytojas";
            this.cmbAKDestytojas.Size = new System.Drawing.Size(226, 21);
            this.cmbAKDestytojas.TabIndex = 12;
            // 
            // btnDeleteDestytojas
            // 
            this.btnDeleteDestytojas.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDestytojas.FlatAppearance.BorderSize = 0;
            this.btnDeleteDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDestytojas.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteDestytojas.Location = new System.Drawing.Point(244, 89);
            this.btnDeleteDestytojas.Name = "btnDeleteDestytojas";
            this.btnDeleteDestytojas.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteDestytojas.TabIndex = 9;
            this.btnDeleteDestytojas.Text = "Ištrinti";
            this.btnDeleteDestytojas.UseVisualStyleBackColor = false;
            this.btnDeleteDestytojas.Click += new System.EventHandler(this.btnDeleteDestytojas_Click);
            // 
            // btnAddDestytojas
            // 
            this.btnAddDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddDestytojas.FlatAppearance.BorderSize = 0;
            this.btnAddDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDestytojas.ForeColor = System.Drawing.Color.Black;
            this.btnAddDestytojas.Location = new System.Drawing.Point(244, 7);
            this.btnAddDestytojas.Name = "btnAddDestytojas";
            this.btnAddDestytojas.Size = new System.Drawing.Size(123, 36);
            this.btnAddDestytojas.TabIndex = 10;
            this.btnAddDestytojas.Text = "Įvesti";
            this.btnAddDestytojas.UseVisualStyleBackColor = true;
            this.btnAddDestytojas.Click += new System.EventHandler(this.btnAddDestytojas_Click);
            // 
            // btnUpdateDestytojas
            // 
            this.btnUpdateDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUpdateDestytojas.FlatAppearance.BorderSize = 0;
            this.btnUpdateDestytojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDestytojas.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDestytojas.Location = new System.Drawing.Point(244, 47);
            this.btnUpdateDestytojas.Name = "btnUpdateDestytojas";
            this.btnUpdateDestytojas.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateDestytojas.TabIndex = 11;
            this.btnUpdateDestytojas.Text = "Pakeisti";
            this.btnUpdateDestytojas.UseVisualStyleBackColor = true;
            this.btnUpdateDestytojas.Click += new System.EventHandler(this.btnUpdateDestytojas_Click);
            // 
            // txtSurnameDestytojas
            // 
            this.txtSurnameDestytojas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurnameDestytojas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSurnameDestytojas.ForeColor = System.Drawing.Color.Gray;
            this.txtSurnameDestytojas.Location = new System.Drawing.Point(12, 89);
            this.txtSurnameDestytojas.Name = "txtSurnameDestytojas";
            this.txtSurnameDestytojas.Size = new System.Drawing.Size(226, 20);
            this.txtSurnameDestytojas.TabIndex = 8;
            this.txtSurnameDestytojas.Text = "Pavarde";
            // 
            // txtNameDestytojas
            // 
            this.txtNameDestytojas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameDestytojas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNameDestytojas.ForeColor = System.Drawing.Color.Gray;
            this.txtNameDestytojas.Location = new System.Drawing.Point(12, 63);
            this.txtNameDestytojas.Name = "txtNameDestytojas";
            this.txtNameDestytojas.Size = new System.Drawing.Size(226, 20);
            this.txtNameDestytojas.TabIndex = 8;
            this.txtNameDestytojas.Text = "Vardas";
            // 
            // tabStudentas
            // 
            this.tabStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabStudentas.Controls.Add(this.txtLSPStudentas);
            this.tabStudentas.Controls.Add(this.btnConfirmUpdateStudentas);
            this.tabStudentas.Controls.Add(this.btnConfirmAddStudentas);
            this.tabStudentas.Controls.Add(this.lblErrorStudent);
            this.tabStudentas.Controls.Add(this.btnDeleteStudentas);
            this.tabStudentas.Controls.Add(this.btnUpdateStudentas);
            this.tabStudentas.Controls.Add(this.btnAddStudentas);
            this.tabStudentas.Controls.Add(this.cmbDegreeStudentas);
            this.tabStudentas.Controls.Add(this.cmbLSPStudentas);
            this.tabStudentas.Controls.Add(this.dtpBirthStudentas);
            this.tabStudentas.Controls.Add(this.txtSurnameStudentas);
            this.tabStudentas.Controls.Add(this.txtNameStudentas);
            this.tabStudentas.Controls.Add(this.cmbFacultyStudentas);
            this.tabStudentas.Location = new System.Drawing.Point(4, 25);
            this.tabStudentas.Name = "tabStudentas";
            this.tabStudentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentas.Size = new System.Drawing.Size(394, 276);
            this.tabStudentas.TabIndex = 3;
            this.tabStudentas.Text = "Studentas";
            // 
            // txtLSPStudentas
            // 
            this.txtLSPStudentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLSPStudentas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtLSPStudentas.ForeColor = System.Drawing.Color.Gray;
            this.txtLSPStudentas.Location = new System.Drawing.Point(13, 7);
            this.txtLSPStudentas.Name = "txtLSPStudentas";
            this.txtLSPStudentas.Size = new System.Drawing.Size(226, 20);
            this.txtLSPStudentas.TabIndex = 34;
            this.txtLSPStudentas.Text = "LSP_Nr";
            // 
            // btnConfirmUpdateStudentas
            // 
            this.btnConfirmUpdateStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmUpdateStudentas.FlatAppearance.BorderSize = 0;
            this.btnConfirmUpdateStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmUpdateStudentas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmUpdateStudentas.Location = new System.Drawing.Point(244, 47);
            this.btnConfirmUpdateStudentas.Name = "btnConfirmUpdateStudentas";
            this.btnConfirmUpdateStudentas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmUpdateStudentas.TabIndex = 33;
            this.btnConfirmUpdateStudentas.UseVisualStyleBackColor = true;
            this.btnConfirmUpdateStudentas.Click += new System.EventHandler(this.btnConfirmUpdateStudentas_Click);
            // 
            // btnConfirmAddStudentas
            // 
            this.btnConfirmAddStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnConfirmAddStudentas.FlatAppearance.BorderSize = 0;
            this.btnConfirmAddStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAddStudentas.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmAddStudentas.Location = new System.Drawing.Point(244, 7);
            this.btnConfirmAddStudentas.Name = "btnConfirmAddStudentas";
            this.btnConfirmAddStudentas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmAddStudentas.TabIndex = 32;
            this.btnConfirmAddStudentas.UseVisualStyleBackColor = true;
            this.btnConfirmAddStudentas.Click += new System.EventHandler(this.btnConfirmAddStudentas_Click);
            // 
            // lblErrorStudent
            // 
            this.lblErrorStudent.AutoSize = true;
            this.lblErrorStudent.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStudent.Location = new System.Drawing.Point(12, 172);
            this.lblErrorStudent.Name = "lblErrorStudent";
            this.lblErrorStudent.Size = new System.Drawing.Size(0, 15);
            this.lblErrorStudent.TabIndex = 31;
            // 
            // btnDeleteStudentas
            // 
            this.btnDeleteStudentas.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudentas.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudentas.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStudentas.Location = new System.Drawing.Point(244, 89);
            this.btnDeleteStudentas.Name = "btnDeleteStudentas";
            this.btnDeleteStudentas.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteStudentas.TabIndex = 30;
            this.btnDeleteStudentas.Text = "Ištrinti";
            this.btnDeleteStudentas.UseVisualStyleBackColor = false;
            this.btnDeleteStudentas.Click += new System.EventHandler(this.btnDeleteStudentas_Click);
            // 
            // btnUpdateStudentas
            // 
            this.btnUpdateStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUpdateStudentas.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudentas.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStudentas.Location = new System.Drawing.Point(244, 47);
            this.btnUpdateStudentas.Name = "btnUpdateStudentas";
            this.btnUpdateStudentas.Size = new System.Drawing.Size(123, 36);
            this.btnUpdateStudentas.TabIndex = 29;
            this.btnUpdateStudentas.Text = "Pakeisti";
            this.btnUpdateStudentas.UseVisualStyleBackColor = true;
            this.btnUpdateStudentas.Click += new System.EventHandler(this.btnUpdateStudentas_Click);
            // 
            // btnAddStudentas
            // 
            this.btnAddStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddStudentas.FlatAppearance.BorderSize = 0;
            this.btnAddStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentas.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudentas.Location = new System.Drawing.Point(244, 7);
            this.btnAddStudentas.Name = "btnAddStudentas";
            this.btnAddStudentas.Size = new System.Drawing.Size(123, 36);
            this.btnAddStudentas.TabIndex = 28;
            this.btnAddStudentas.Text = "Įvesti";
            this.btnAddStudentas.UseVisualStyleBackColor = true;
            this.btnAddStudentas.Click += new System.EventHandler(this.btnAddStudentas_Click);
            // 
            // cmbDegreeStudentas
            // 
            this.cmbDegreeStudentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDegreeStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDegreeStudentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbDegreeStudentas.FormattingEnabled = true;
            this.cmbDegreeStudentas.Items.AddRange(new object[] {
            "Bakalauras 1 kursas",
            "Bakalauras 2 kursas",
            "Bakalauras 3 kursas",
            "Bakalauras 4 kursas",
            "Magistras 1 kursas",
            "Magistras 2 kursas"});
            this.cmbDegreeStudentas.Location = new System.Drawing.Point(12, 144);
            this.cmbDegreeStudentas.Name = "cmbDegreeStudentas";
            this.cmbDegreeStudentas.Size = new System.Drawing.Size(226, 21);
            this.cmbDegreeStudentas.TabIndex = 27;
            // 
            // cmbLSPStudentas
            // 
            this.cmbLSPStudentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLSPStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLSPStudentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbLSPStudentas.FormattingEnabled = true;
            this.cmbLSPStudentas.Location = new System.Drawing.Point(13, 6);
            this.cmbLSPStudentas.Name = "cmbLSPStudentas";
            this.cmbLSPStudentas.Size = new System.Drawing.Size(226, 21);
            this.cmbLSPStudentas.TabIndex = 26;
            // 
            // dtpBirthStudentas
            // 
            this.dtpBirthStudentas.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthStudentas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthStudentas.Location = new System.Drawing.Point(11, 115);
            this.dtpBirthStudentas.Name = "dtpBirthStudentas";
            this.dtpBirthStudentas.Size = new System.Drawing.Size(228, 23);
            this.dtpBirthStudentas.TabIndex = 23;
            this.dtpBirthStudentas.Value = new System.DateTime(1998, 12, 9, 0, 0, 0, 0);
            this.dtpBirthStudentas.ValueChanged += new System.EventHandler(this.dtpBirthStudentas_ValueChanged);
            // 
            // txtSurnameStudentas
            // 
            this.txtSurnameStudentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurnameStudentas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSurnameStudentas.ForeColor = System.Drawing.Color.Gray;
            this.txtSurnameStudentas.Location = new System.Drawing.Point(12, 89);
            this.txtSurnameStudentas.Name = "txtSurnameStudentas";
            this.txtSurnameStudentas.Size = new System.Drawing.Size(226, 20);
            this.txtSurnameStudentas.TabIndex = 19;
            this.txtSurnameStudentas.Text = "Pavarde";
            // 
            // txtNameStudentas
            // 
            this.txtNameStudentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameStudentas.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNameStudentas.ForeColor = System.Drawing.Color.Gray;
            this.txtNameStudentas.Location = new System.Drawing.Point(12, 63);
            this.txtNameStudentas.Name = "txtNameStudentas";
            this.txtNameStudentas.Size = new System.Drawing.Size(226, 20);
            this.txtNameStudentas.TabIndex = 20;
            this.txtNameStudentas.Text = "Vardas";
            // 
            // cmbFacultyStudentas
            // 
            this.cmbFacultyStudentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacultyStudentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFacultyStudentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.cmbFacultyStudentas.FormattingEnabled = true;
            this.cmbFacultyStudentas.Location = new System.Drawing.Point(12, 34);
            this.cmbFacultyStudentas.Name = "cmbFacultyStudentas";
            this.cmbFacultyStudentas.Size = new System.Drawing.Size(226, 21);
            this.cmbFacultyStudentas.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(360, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(336, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 10);
            this.panel3.TabIndex = 0;
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(383, 301);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditWindow";
            this.Text = "EditWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabFakultetas.ResumeLayout(false);
            this.tabFakultetas.PerformLayout();
            this.tabDalykas.ResumeLayout(false);
            this.tabDalykas.PerformLayout();
            this.tabDestytojas.ResumeLayout(false);
            this.tabDestytojas.PerformLayout();
            this.tabStudentas.ResumeLayout(false);
            this.tabStudentas.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtAddress_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressFakultetas.Text))
            {
                txtAddressFakultetas.Text = "Iveskite Adresa";
                txtAddressFakultetas.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddressFakultetas.Text = "";
            txtAddressFakultetas.ForeColor = System.Drawing.Color.Black;
        }

        private void txtPhoneNr_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPhoneNrFakultetas.Text))
            {
                txtPhoneNrFakultetas.Text = "Iveskite Telefono Nr";
                txtPhoneNrFakultetas.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPhoneNr_Click(object sender, EventArgs e)
        {
            txtPhoneNrFakultetas.Text = "";
            txtPhoneNrFakultetas.ForeColor = System.Drawing.Color.Black;
        }

        private void TxtTitle_Click(object sender, EventArgs e)
        {
            txtTitleFakultetas.Text = "";
            txtTitleFakultetas.ForeColor = System.Drawing.Color.Black;
        }

        private void txtTitle_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitleFakultetas.Text))
            {
                txtTitleFakultetas.Text = "Iveskite pavadinima";
                txtTitleFakultetas.ForeColor = System.Drawing.Color.Gray;
            }

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFakultetas;
        private System.Windows.Forms.TabPage tabDalykas;
        private System.Windows.Forms.TabPage tabDestytojas;
        private System.Windows.Forms.TabPage tabStudentas;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPhoneNrFakultetas;
        private System.Windows.Forms.TextBox txtAddressFakultetas;
        private System.Windows.Forms.TextBox txtTitleFakultetas;
        private System.Windows.Forms.Button btnDeleteFakultetas;
        private System.Windows.Forms.Button btnAddFakultetas;
        private System.Windows.Forms.Button btnUpdateFakultetas;
        private System.Windows.Forms.TextBox txtCreditsDalykas;
        private System.Windows.Forms.TextBox txtTitleDalykas;
        private System.Windows.Forms.TextBox txtSurnameDestytojas;
        private System.Windows.Forms.TextBox txtNameDestytojas;
        private System.Windows.Forms.Button btnDeleteDalykas;
        private System.Windows.Forms.Button btnAddDalykas;
        private System.Windows.Forms.Button btnUpdateDalykas;
        private System.Windows.Forms.Button btnDeleteDestytojas;
        private System.Windows.Forms.Button btnAddDestytojas;
        private System.Windows.Forms.Button btnUpdateDestytojas;
        private System.Windows.Forms.Label lblErrorFaculty;
        private System.Windows.Forms.Button btnConfirmUpdateFakultetas;
        private System.Windows.Forms.Label lblErrorCourse;
        private System.Windows.Forms.ComboBox cmbIDDalykas;
        private System.Windows.Forms.Button btnConfirmUpdateDalykas;
        private System.Windows.Forms.ComboBox cmbAKDestytojas;
        private System.Windows.Forms.Label lblErrorLecturer;
        private System.Windows.Forms.ComboBox cmbFacultyDestytojas;
        private System.Windows.Forms.TextBox txtAKDestytojas;
        private System.Windows.Forms.Button btnConfirmAddDestytojas;
        private System.Windows.Forms.Button btnConfirmUpdateDestytojas;
        private System.Windows.Forms.ComboBox cmbDegreeDestytojas;
        private System.Windows.Forms.ComboBox cmbLSPStudentas;
        private System.Windows.Forms.DateTimePicker dtpBirthStudentas;
        private System.Windows.Forms.TextBox txtSurnameStudentas;
        private System.Windows.Forms.TextBox txtNameStudentas;
        private System.Windows.Forms.ComboBox cmbFacultyStudentas;
        private System.Windows.Forms.ComboBox cmbDegreeStudentas;
        private System.Windows.Forms.Button btnDeleteStudentas;
        private System.Windows.Forms.Button btnUpdateStudentas;
        private System.Windows.Forms.Button btnAddStudentas;
        private System.Windows.Forms.Label lblErrorStudent;
        private System.Windows.Forms.Button btnConfirmUpdateStudentas;
        private System.Windows.Forms.Button btnConfirmAddStudentas;
        private System.Windows.Forms.TextBox txtLSPStudentas;
    }
}