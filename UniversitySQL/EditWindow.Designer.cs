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
            this.lblError = new System.Windows.Forms.Label();
            this.btnDeleteFakultetas = new System.Windows.Forms.Button();
            this.btnAddFakultetas = new System.Windows.Forms.Button();
            this.btnUpdateFakultetas = new System.Windows.Forms.Button();
            this.txtPhoneNrFakultetas = new System.Windows.Forms.TextBox();
            this.txtAddressFakultetas = new System.Windows.Forms.TextBox();
            this.txtTitleFakultetas = new System.Windows.Forms.TextBox();
            this.tabDalykas = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddDalykas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabDestytojas = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabStudentas = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabFakultetas.SuspendLayout();
            this.tabDalykas.SuspendLayout();
            this.tabDestytojas.SuspendLayout();
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
            this.tabFakultetas.Controls.Add(this.lblError);
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
            this.btnConfirmUpdateFakultetas.Location = new System.Drawing.Point(244, 48);
            this.btnConfirmUpdateFakultetas.Name = "btnConfirmUpdateFakultetas";
            this.btnConfirmUpdateFakultetas.Size = new System.Drawing.Size(123, 36);
            this.btnConfirmUpdateFakultetas.TabIndex = 5;
            this.btnConfirmUpdateFakultetas.UseVisualStyleBackColor = true;
            this.btnConfirmUpdateFakultetas.Click += new System.EventHandler(this.btnConfirmUpdateFakultetas_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(12, 89);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 4;
            // 
            // btnDeleteFakultetas
            // 
            this.btnDeleteFakultetas.BackColor = System.Drawing.Color.Red;
            this.btnDeleteFakultetas.FlatAppearance.BorderSize = 0;
            this.btnDeleteFakultetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txtPhoneNrFakultetas.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNrFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNrFakultetas.Location = new System.Drawing.Point(12, 63);
            this.txtPhoneNrFakultetas.Name = "txtPhoneNrFakultetas";
            this.txtPhoneNrFakultetas.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNrFakultetas.TabIndex = 2;
            this.txtPhoneNrFakultetas.Text = "Telefono Nr.";
            // 
            // txtAddressFakultetas
            // 
            this.txtAddressFakultetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddressFakultetas.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtAddressFakultetas.Location = new System.Drawing.Point(12, 35);
            this.txtAddressFakultetas.Name = "txtAddressFakultetas";
            this.txtAddressFakultetas.Size = new System.Drawing.Size(200, 20);
            this.txtAddressFakultetas.TabIndex = 1;
            this.txtAddressFakultetas.Text = "Adresas";
            // 
            // txtTitleFakultetas
            // 
            this.txtTitleFakultetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(3)))));
            this.txtTitleFakultetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleFakultetas.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleFakultetas.ForeColor = System.Drawing.Color.Gray;
            this.txtTitleFakultetas.Location = new System.Drawing.Point(12, 7);
            this.txtTitleFakultetas.Name = "txtTitleFakultetas";
            this.txtTitleFakultetas.Size = new System.Drawing.Size(200, 20);
            this.txtTitleFakultetas.TabIndex = 0;
            this.txtTitleFakultetas.Text = "Pavadinimas";
            // 
            // tabDalykas
            // 
            this.tabDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabDalykas.Controls.Add(this.button1);
            this.tabDalykas.Controls.Add(this.btnAddDalykas);
            this.tabDalykas.Controls.Add(this.button3);
            this.tabDalykas.Controls.Add(this.textBox1);
            this.tabDalykas.Controls.Add(this.textBox2);
            this.tabDalykas.Controls.Add(this.textBox3);
            this.tabDalykas.Location = new System.Drawing.Point(4, 25);
            this.tabDalykas.Name = "tabDalykas";
            this.tabDalykas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDalykas.Size = new System.Drawing.Size(394, 276);
            this.tabDalykas.TabIndex = 1;
            this.tabDalykas.Text = "Dalykas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(244, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ištrinti";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddDalykas
            // 
            this.btnAddDalykas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddDalykas.FlatAppearance.BorderSize = 0;
            this.btnAddDalykas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDalykas.Location = new System.Drawing.Point(244, 7);
            this.btnAddDalykas.Name = "btnAddDalykas";
            this.btnAddDalykas.Size = new System.Drawing.Size(123, 36);
            this.btnAddDalykas.TabIndex = 7;
            this.btnAddDalykas.Text = "Įvesti";
            this.btnAddDalykas.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(244, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Pakeisti";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Kreditu sk.";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(12, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Pavadinimas";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(12, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "ID";
            // 
            // tabDestytojas
            // 
            this.tabDestytojas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabDestytojas.Controls.Add(this.button4);
            this.tabDestytojas.Controls.Add(this.button5);
            this.tabDestytojas.Controls.Add(this.button6);
            this.tabDestytojas.Controls.Add(this.textBox8);
            this.tabDestytojas.Controls.Add(this.textBox7);
            this.tabDestytojas.Controls.Add(this.textBox4);
            this.tabDestytojas.Controls.Add(this.textBox5);
            this.tabDestytojas.Controls.Add(this.textBox6);
            this.tabDestytojas.Location = new System.Drawing.Point(4, 25);
            this.tabDestytojas.Name = "tabDestytojas";
            this.tabDestytojas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestytojas.Size = new System.Drawing.Size(394, 276);
            this.tabDestytojas.TabIndex = 2;
            this.tabDestytojas.Text = "Dėstytojas";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(244, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Ištrinti";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(244, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "Įvesti";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(244, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 36);
            this.button6.TabIndex = 11;
            this.button6.Text = "Pakeisti";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Gray;
            this.textBox8.Location = new System.Drawing.Point(12, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "Laipsnis";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Gray;
            this.textBox7.Location = new System.Drawing.Point(12, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Pavarde";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Gray;
            this.textBox4.Location = new System.Drawing.Point(12, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Vardas";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Gray;
            this.textBox5.Location = new System.Drawing.Point(12, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Fakultetas";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Gray;
            this.textBox6.Location = new System.Drawing.Point(12, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Asmens Kodas";
            // 
            // tabStudentas
            // 
            this.tabStudentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.tabStudentas.Location = new System.Drawing.Point(4, 25);
            this.tabStudentas.Name = "tabStudentas";
            this.tabStudentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentas.Size = new System.Drawing.Size(394, 276);
            this.tabStudentas.TabIndex = 3;
            this.tabStudentas.Text = "Studentas";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddDalykas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnConfirmUpdateFakultetas;
    }
}