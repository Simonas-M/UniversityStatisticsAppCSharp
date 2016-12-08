using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySQL
{
    public partial class EditWindow : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        Fakultetas exsistingFaculty = null;

        string tempTextBoxText;

        public EditWindow()
        {
            InitializeComponent();
            btnConfirmUpdateFakultetas.Hide();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CheckFakultetasInfo()
        {
            try
            {
                if (txtTitleFakultetas.Text.Length > 38)
                {
                    txtTitleFakultetas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 38 simboliai");
                }
                else if (string.IsNullOrWhiteSpace(txtTitleFakultetas.Text))
                {
                    txtTitleFakultetas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtTitleFakultetas.Text);
                }
                else if (txtAddressFakultetas.Text.Length > 38)
                {
                    txtAddressFakultetas.BackColor = Color.Salmon;
                    throw new ArgumentException("Adresas negali būti" + Environment.NewLine + "ilgesnis negu 38 simboliai");
                }

                else if (string.IsNullOrWhiteSpace(txtAddressFakultetas.Text))
                {
                    txtAddressFakultetas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtAddressFakultetas.Text);
                }

                else if (!new System.Text.RegularExpressions.Regex(@"^\+370\d{8}$").IsMatch(txtPhoneNrFakultetas.Text))
                {
                    txtPhoneNrFakultetas.BackColor = Color.Salmon;
                    throw new ArgumentException("Telefono numeris" + Environment.NewLine + "turi būti +370X XXX XXXX");
                }

            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAddressFakultetas.BackColor = SystemColors.Control;
            txtPhoneNrFakultetas.BackColor = SystemColors.Control;
            try
            {
                CheckFakultetasInfo();
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                if (db.Fakultetas.Find(txtTitleFakultetas.Text) != null)
                {
                    lblError.Text = "Fakultetas pavadinimu" + Environment.NewLine + "\"" +txtTitleFakultetas.Text + "\" jau egzistuoja";
                    return;
                }

                Fakultetas faculty = new Fakultetas();
                faculty.Pavadinimas = txtTitleFakultetas.Text;
                faculty.Adresas = txtAddressFakultetas.Text;
                faculty.Telefono_Nr = txtPhoneNrFakultetas.Text;

                db.Fakultetas.Add(faculty);
                db.SaveChanges();
            }
            lblError.Text = "Įvesta";
        }

        private void btnUpdateFakultetas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingFaculty = db.Fakultetas.Find(txtTitleFakultetas.Text);
                if (exsistingFaculty != null)
                {
                    btnConfirmUpdateFakultetas.Show();
                    btnConfirmUpdateFakultetas.Text = "Patvirtinti";
                    btnConfirmUpdateFakultetas.BackColor = Color.Green;
                    lblError.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
                    txtTitleFakultetas.Enabled = false;
                    btnDeleteFakultetas.Enabled = false;
                    btnAddFakultetas.Enabled = false;
                }
                else
                    lblError.Text = "Toks fakultetas nerastas";
            }
        }

        private void btnConfirmUpdateFakultetas_Click(object sender, EventArgs e)
        {
            btnConfirmUpdateFakultetas.Hide();
            txtTitleFakultetas.Enabled = true;
            btnDeleteFakultetas.Enabled = true;
            btnAddFakultetas.Enabled = true;
            try
            {
                CheckFakultetasInfo();
            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingFaculty.Pavadinimas = txtTitleFakultetas.Text;
                exsistingFaculty.Adresas = txtAddressFakultetas.Text;
                exsistingFaculty.Telefono_Nr = txtPhoneNrFakultetas.Text;

                db.Entry(exsistingFaculty).State = System.Data.Entity.EntityState.Modified;

                bool saveFailed;
                do
                {
                    saveFailed = false;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
                    {
                        saveFailed = true;

                        exsistingFaculty.Pavadinimas = txtTitleFakultetas.Text;
                        exsistingFaculty.Adresas = txtAddressFakultetas.Text;
                        exsistingFaculty.Telefono_Nr = txtPhoneNrFakultetas.Text;

                        ex.Entries.Single().Reload();
                    }

                } while (saveFailed);

            }
            lblError.Text = "Pakeista";
        }

        private void btnDeleteFakultetas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingFaculty = db.Fakultetas.Find(txtTitleFakultetas.Text);
                if (exsistingFaculty != null)
                {
                    db.Fakultetas.Remove(exsistingFaculty);
                    lblError.Text = "Ištrinta";
                    db.SaveChanges();
                }
                else
                    lblError.Text = "Fakultetas nerastas!";
            }

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            tempTextBoxText = box.Text;
            box.Text = "";
            box.ForeColor = System.Drawing.Color.Black;
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (String.IsNullOrEmpty(box.Text))
            {
                box.Text = tempTextBoxText;
                box.ForeColor = System.Drawing.Color.Gray;
            }

        }
    }
}
