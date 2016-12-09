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
        Dalykas exsistingCourse = null;
        Destytojas exsistingLecturer = null;
        Studentas exsistingStudent = null;

        string tempTextBoxText;

        Dictionary<Guid, string> CourseIDs = new Dictionary<Guid, string>();
        Dictionary<string, string> LecturersAKs = new Dictionary<string, string>();
        Dictionary<string, string> StudentLSPs = new Dictionary<string, string>();

        public EditWindow()
        {
            InitializeComponent();
            UpdateIdsDalykas();
            UpdateAKsDestytojas();
            UpdateFaculties();
            UpdateLSPStudentas();
            cmbDegreeDestytojas.SelectedIndex = 0;
            cmbDegreeStudentas.SelectedIndex = 0;
            btnConfirmUpdateFakultetas.Hide();
            btnConfirmUpdateDalykas.Hide();
            btnConfirmAddDestytojas.Hide();
            btnConfirmUpdateDestytojas.Hide();
            btnConfirmAddStudentas.Hide();
            btnConfirmUpdateStudentas.Hide();
            txtAKDestytojas.Hide();
            txtLSPStudentas.Hide();
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
                    throw new ArgumentException("Telefono numeris" + Environment.NewLine + "turi būti +370XXXXXXXX");
                }

            }
            catch (Exception)
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
                lblErrorFaculty.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                if (db.Fakultetas.Find(txtTitleFakultetas.Text) != null)
                {
                    lblErrorFaculty.Text = "Fakultetas pavadinimu" + Environment.NewLine + "\"" + txtTitleFakultetas.Text + "\" jau egzistuoja";
                    return;
                }

                Fakultetas faculty = new Fakultetas();
                faculty.Pavadinimas = txtTitleFakultetas.Text;
                faculty.Adresas = txtAddressFakultetas.Text;
                faculty.Telefono_Nr = txtPhoneNrFakultetas.Text;

                db.Fakultetas.Add(faculty);
                db.SaveChanges();
            }
            lblErrorFaculty.Text = "Įvesta";
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
                    lblErrorFaculty.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
                    txtTitleFakultetas.Enabled = false;
                    btnDeleteFakultetas.Enabled = false;
                    btnAddFakultetas.Enabled = false;
                }
                else
                    lblErrorFaculty.Text = "Toks fakultetas nerastas";
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
                lblErrorFaculty.Text = exc.Message;
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
            lblErrorFaculty.Text = "Pakeista";
        }

        private void btnDeleteFakultetas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingFaculty = db.Fakultetas.Find(txtTitleFakultetas.Text);
                if (exsistingFaculty != null)
                {
                    db.Fakultetas.Remove(exsistingFaculty);
                    lblErrorFaculty.Text = "Ištrinta";
                    db.SaveChanges();
                }
                else
                    lblErrorFaculty.Text = "Toks fakultetas nerastas!";
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

        private void btnAddDalykas_Click(object sender, EventArgs e)
        {
            txtTitleDalykas.BackColor = SystemColors.Control;
            txtCreditsDalykas.BackColor = SystemColors.Control;
            try
            {
                if (cmbIDDalykas.SelectedIndex != 0)
                    throw new ArgumentException("Norint pridėti" + Environment.NewLine + "pasirinkite \"Sukurti naują\"");
                CheckDalykasInfo();
            }
            catch (Exception exc)
            {
                lblErrorCourse.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                Dalykas course = new Dalykas();
                course.ID = Guid.NewGuid();
                course.Pavadinimas = txtTitleDalykas.Text;
                course.Kreditu_Sk = Int16.Parse(txtCreditsDalykas.Text);

                db.Dalykas.Add(course);
                db.SaveChanges();
            }
            lblErrorCourse.Text = "Įvesta";
            UpdateIdsDalykas();
        }

        private void CheckDalykasInfo()
        {
            try
            {
                if (txtTitleDalykas.Text.Length > 30)
                {
                    txtTitleDalykas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 30 simbolių");
                }
                else if (string.IsNullOrWhiteSpace(txtTitleDalykas.Text))
                {
                    txtTitleDalykas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtTitleDalykas.Text);
                }
                else if (Int16.Parse(txtCreditsDalykas.Text) < 1 || Int16.Parse(txtCreditsDalykas.Text) > 10)
                {
                    txtCreditsDalykas.BackColor = Color.Salmon;
                    throw new ArgumentException("Dalyko kreditų skaičius" + Environment.NewLine + "privalo būti intervale (1-10)");
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Kreditų kiekis turi būti skaičius!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateIdsDalykas()
        {
            CourseIDs.Clear();
            cmbIDDalykas.Items.Clear();
            CourseIDs.Add(default(Guid), "Sukurti naują");
            cmbIDDalykas.Items.Add("Sukurti naują");
            cmbIDDalykas.SelectedIndex = 0;

            using (var db = new UniversityContext())
            {
                var query = from a in db.Dalykas
                            select a;

                foreach (var item in query)
                {
                    CourseIDs.Add(item.ID, "~hash:" + item.Pavadinimas);
                    cmbIDDalykas.Items.Add("~hash:" + item.Pavadinimas);
                }
            }
        }

        private void btnUpdateDalykas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingCourse = db.Dalykas.Find(CourseIDs.FirstOrDefault(x => x.Value == cmbIDDalykas.SelectedItem.ToString()).Key);
                if (exsistingCourse != null)
                {
                    btnConfirmUpdateDalykas.Show();
                    btnConfirmUpdateDalykas.Text = "Patvirtinti";
                    btnConfirmUpdateDalykas.BackColor = Color.Green;
                    lblErrorCourse.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
                    cmbIDDalykas.Enabled = false;
                    btnDeleteDalykas.Enabled = false;
                    btnAddDalykas.Enabled = false;
                }
            }
        }

        private void btnConfirmUpdateDalykas_Click(object sender, EventArgs e)
        {
            btnConfirmUpdateDalykas.Hide();
            cmbIDDalykas.Enabled = true;
            btnDeleteDalykas.Enabled = true;
            btnAddDalykas.Enabled = true;
            try
            {
                CheckDalykasInfo();
            }
            catch (Exception exc)
            {
                lblErrorCourse.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingCourse.Pavadinimas = txtTitleDalykas.Text;
                exsistingCourse.Kreditu_Sk = Int16.Parse(txtCreditsDalykas.Text);

                db.Entry(exsistingCourse).State = System.Data.Entity.EntityState.Modified;

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

                        //exsistingCourse.Pavadinimas = txtTitleDalykas.Text;
                        //exsistingCourse.Kreditu_Sk = Int16.Parse(txtAddressFakultetas.Text);

                        ex.Entries.Single().Reload();
                    }

                } while (saveFailed);

            }
            lblErrorCourse.Text = "Pakeista";
            UpdateIdsDalykas();
        }

        private void btnDeleteDalykas_Click(object sender, EventArgs e)
        {
            if (cmbIDDalykas.SelectedIndex == 0)
            {
                lblErrorCourse.Text = "Pirma pasirinkite ID";
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingCourse = db.Dalykas.Find(CourseIDs.FirstOrDefault(x => x.Value == cmbIDDalykas.SelectedItem.ToString()).Key);
                if (exsistingCourse != null)
                {
                    db.Dalykas.Remove(exsistingCourse);
                    lblErrorCourse.Text = "Ištrinta";
                    db.SaveChanges();
                }
            }
            UpdateIdsDalykas();
        }

        private void btnAddDestytojas_Click(object sender, EventArgs e)
        {
            txtNameDestytojas.BackColor = SystemColors.Control;
            txtSurnameDestytojas.BackColor = SystemColors.Control;

            try
            {
                if (cmbAKDestytojas.SelectedIndex != 0)
                    throw new ArgumentException("Norint pridėti" + Environment.NewLine + "pasirinkite \"Sukurti naują\"");
            }
            catch (Exception exc)
            {
                lblErrorLecturer.Text = exc.Message;
                return;
            }

            txtAKDestytojas.Show();
            btnConfirmAddDestytojas.Show();
            cmbIDDalykas.Hide();
            btnConfirmAddDestytojas.Text = "Patvirtinti";
            btnConfirmAddDestytojas.BackColor = Color.Green;
            lblErrorLecturer.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
            btnDeleteDestytojas.Enabled = false;
            btnUpdateDestytojas.Enabled = false;
        }

        private void UpdateAKsDestytojas()
        {
            LecturersAKs.Clear();
            cmbAKDestytojas.Items.Clear();
            LecturersAKs.Add("01010101010", "Sukurti naują");
            cmbAKDestytojas.Items.Add("Sukurti naują");
            cmbAKDestytojas.SelectedIndex = 0;

            using (var db = new UniversityContext())
            {
                var query = from a in db.Destytojas
                            select a;

                foreach (var item in query)
                {
                    LecturersAKs.Add(item.Asmens_Kodas, item.Asmens_Kodas + ": " + item.Vardas + " " + item.Pavarde);
                    cmbAKDestytojas.Items.Add(item.Asmens_Kodas + ": " + item.Vardas + " " + item.Pavarde);
                }
            }
        }

        private void UpdateFaculties()
        {
            cmbFacultyDestytojas.Items.Clear();
            cmbFacultyStudentas.Items.Clear();

            using (var db = new UniversityContext())
            {
                var query = from a in db.Fakultetas
                            select a.Pavadinimas;

                foreach (var item in query)
                {
                    cmbFacultyDestytojas.Items.Add(item);
                    cmbFacultyStudentas.Items.Add(item);
                }
                cmbFacultyDestytojas.SelectedIndex = 0;
                cmbFacultyStudentas.SelectedIndex = 0;
            }
        }

        private void CheckDestytojasInfo()
        {
            try
            {
                if (txtNameDestytojas.Text.Length > 15)
                {
                    txtNameDestytojas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 15 simbolių");
                }
                else if (string.IsNullOrWhiteSpace(txtNameDestytojas.Text))
                {
                    txtNameDestytojas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtNameDestytojas.Text);
                }
                else if (txtSurnameDestytojas.Text.Length > 20)
                {
                    txtSurnameDestytojas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 20 simbolių");
                }
                else if (string.IsNullOrWhiteSpace(txtSurnameDestytojas.Text))
                {
                    txtSurnameDestytojas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtSurnameDestytojas.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnConfirmAddDestytojas_Click(object sender, EventArgs e)
        {
            txtAKDestytojas.Hide();
            btnConfirmAddDestytojas.Hide();
            cmbIDDalykas.Show();
            btnDeleteDestytojas.Enabled = true;
            btnUpdateDestytojas.Enabled = true;

            try
            {
                if (!new System.Text.RegularExpressions.Regex(@"[3-6][0-9]{2}[0,1][0-9][0-9]{2}[0-9]{4}").IsMatch(txtAKDestytojas.Text))
                    throw new ArgumentException("Asmens kodas turi būti legalus");
                else if (LecturersAKs.ContainsKey(txtAKDestytojas.Text))
                    throw new ArgumentException("Toks Asmens kodas" + Environment.NewLine + "jau yra duomenų bazėje!");
                CheckDestytojasInfo();
            }
            catch (Exception exc)
            {
                lblErrorLecturer.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                Destytojas lecturer = new Destytojas();
                lecturer.Asmens_Kodas = txtAKDestytojas.Text;
                lecturer.Fakultetas = cmbFacultyDestytojas.SelectedItem.ToString();
                lecturer.Vardas = txtNameDestytojas.Text;
                lecturer.Pavarde = txtSurnameDestytojas.Text;
                lecturer.Laipsnis = cmbDegreeDestytojas.SelectedItem.ToString();

                db.Destytojas.Add(lecturer);
                db.SaveChanges();
            }
            lblErrorLecturer.Text = "Įvesta";
            UpdateAKsDestytojas();
        }

        private void btnUpdateDestytojas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingLecturer = db.Destytojas.Find(LecturersAKs.FirstOrDefault(x => x.Value == cmbAKDestytojas.SelectedItem.ToString()).Key);
                if (exsistingLecturer != null)
                {
                    btnConfirmUpdateDestytojas.Show();
                    btnConfirmUpdateDestytojas.Text = "Patvirtinti";
                    btnConfirmUpdateDestytojas.BackColor = Color.Green;
                    lblErrorLecturer.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
                    cmbAKDestytojas.Enabled = false;
                    btnDeleteDestytojas.Enabled = false;
                    btnAddDestytojas.Enabled = false;
                }
            }
        }

        private void btnConfirmUpdateDestytojas_Click(object sender, EventArgs e)
        {
            btnConfirmUpdateDestytojas.Hide();
            cmbAKDestytojas.Enabled = true;
            btnDeleteDestytojas.Enabled = true;
            btnAddDestytojas.Enabled = true;

            try
            {
                CheckDestytojasInfo();
            }
            catch (Exception exc)
            {
                lblErrorCourse.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingLecturer.Fakultetas = cmbFacultyDestytojas.SelectedItem.ToString();
                exsistingLecturer.Vardas = txtNameDestytojas.Text;
                exsistingLecturer.Pavarde = txtSurnameDestytojas.Text;
                exsistingLecturer.Laipsnis = cmbDegreeDestytojas.SelectedItem.ToString();

                db.Entry(exsistingLecturer).State = System.Data.Entity.EntityState.Modified;

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

                        //exsistingCourse.Pavadinimas = txtTitleDalykas.Text;
                        //exsistingCourse.Kreditu_Sk = Int16.Parse(txtAddressFakultetas.Text);

                        ex.Entries.Single().Reload();
                    }

                } while (saveFailed);

            }
            lblErrorLecturer.Text = "Pakeista";
            UpdateAKsDestytojas();
        }

        private void btnDeleteDestytojas_Click(object sender, EventArgs e)
        {
            if (cmbAKDestytojas.SelectedIndex == 0)
            {
                lblErrorLecturer.Text = "Pirma pasirinkite Destytoją";
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingLecturer = db.Destytojas.Find(LecturersAKs.FirstOrDefault(x => x.Value == cmbAKDestytojas.SelectedItem.ToString()).Key);
                if (exsistingLecturer != null)
                {
                    db.Destytojas.Remove(exsistingLecturer);
                    lblErrorLecturer.Text = "Ištrinta";
                    db.SaveChanges();
                }
            }
            UpdateAKsDestytojas();
        }

        private void UpdateLSPStudentas()
        {
            StudentLSPs.Clear();
            cmbLSPStudentas.Items.Clear();
            StudentLSPs.Add("0101010", "Sukurti naują");
            cmbLSPStudentas.Items.Add("LSP_Nr:Sukurti naują");

            using (var db = new UniversityContext())
            {
                var query = from a in db.Studentas
                            select a;

                foreach (var item in query)
                {
                    StudentLSPs.Add(item.LSP_Nr, item.LSP_Nr + ":" + item.Vardas + " " + item.Pavarde);
                    cmbLSPStudentas.Items.Add(item.LSP_Nr + ":" + item.Vardas + " " + item.Pavarde);
                }
                cmbLSPStudentas.SelectedIndex = 0;
            }
        }

        private void btnAddStudentas_Click(object sender, EventArgs e)
        {
            txtNameStudentas.BackColor = SystemColors.Control;
            txtSurnameStudentas.BackColor = SystemColors.Control;

            try
            {
                if (cmbLSPStudentas.SelectedIndex != 0)
                    throw new ArgumentException("Norint pridėti" + Environment.NewLine + "pasirinkite \"Sukurti naują\"");
            }
            catch (Exception exc)
            {
                lblErrorStudent.Text = exc.Message;
                return;
            }

            txtLSPStudentas.Show();
            btnConfirmAddStudentas.Show();
            cmbLSPStudentas.Hide();
            btnConfirmAddStudentas.Text = "Patvirtinti";
            btnConfirmAddStudentas.BackColor = Color.Green;
            lblErrorStudent.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
            btnDeleteStudentas.Enabled = false;
            btnUpdateStudentas.Enabled = false;
        }

        private void CheckStudentasInfo()
        {
            try
            {
                if (!new System.Text.RegularExpressions.Regex(@"^\d{7}").IsMatch(txtLSPStudentas.Text))
                    throw new ArgumentException("LSP numeri turi sudaryti" + Environment.NewLine + "7 skaitmenys");
                else if (txtNameStudentas.Text.Length > 15)
                {
                    txtNameStudentas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 15 simbolių");
                }
                else if (string.IsNullOrWhiteSpace(txtNameStudentas.Text))
                {
                    txtNameDestytojas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtNameStudentas.Text);
                }
                else if (txtSurnameStudentas.Text.Length > 20)
                {
                    txtSurnameStudentas.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali būti" + Environment.NewLine + "ilgesnis negu 20 simbolių");
                }
                else if (string.IsNullOrWhiteSpace(txtSurnameStudentas.Text))
                {
                    txtSurnameStudentas.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtSurnameStudentas.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnConfirmAddStudentas_Click(object sender, EventArgs e)
        {
            txtLSPStudentas.Hide();
            btnConfirmAddStudentas.Hide();
            cmbLSPStudentas.Show();
            btnDeleteStudentas.Enabled = true;
            btnUpdateStudentas.Enabled = true;

            try
            {
                if (StudentLSPs.ContainsKey(txtLSPStudentas.Text))
                    throw new ArgumentException("Toks LSP numeris" + Environment.NewLine + "jau yra duomenų bazėje!");
                CheckStudentasInfo();
            }
            catch (Exception exc)
            {
                lblErrorStudent.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                Studentas student = new Studentas();
                student.LSP_Nr  = txtLSPStudentas.Text;
                student.Fakultetas = cmbFacultyStudentas.SelectedItem.ToString();
                student.Vardas = txtNameStudentas.Text;
                student.Pavarde = txtSurnameStudentas.Text;
                student.Gimimas = dtpBirthStudentas.Value;
                
                switch(cmbDegreeStudentas.SelectedIndex)
                {
                    case 0:
                        student.Kursas = 1;
                        student.Pakopa = "Bakalauras";
                        break;
                    case 1:
                        student.Kursas = 2;
                        student.Pakopa = "Bakalauras";
                        break;
                    case 2:
                        student.Kursas = 3;
                        student.Pakopa = "Bakalauras";
                        break;
                    case 3:
                        student.Kursas = 4;
                        student.Pakopa = "Bakalauras";
                        break;
                    case 4:
                        student.Kursas = 1;
                        student.Pakopa = "Magistras";
                        break;
                    case 5:
                        student.Kursas = 2;
                        student.Pakopa = "Magistras";
                        break;
                }

                db.Studentas.Add(student);
                db.SaveChanges();
            }
            lblErrorStudent.Text = "Įvesta";
            UpdateLSPStudentas();
        }

        private void dtpBirthStudentas_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpBirthStudentas.Value < new DateTime(1900, 01, 01))
                    throw new DateOutOfRangeException(new DateTime(1900, 01, 01), "Metai negali būti" + Environment.NewLine + "ankstesni nei 1900-01-01!");
                else if (dtpBirthStudentas.Value > DateTime.Today.AddYears(-18))
                    throw new DateOutOfRangeException(DateTime.Today.AddYears(-18), "Studentas turi būti" + Environment.NewLine + "18 metų arba vyresnis!");
            }
            catch (DateOutOfRangeException exc)
            {
                lblErrorStudent.Text = exc.Message;
                dtpBirthStudentas.Value = exc.Time;
            }
        }

        private void btnUpdateStudentas_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                exsistingStudent = db.Studentas.Find(StudentLSPs.FirstOrDefault(x => x.Value == cmbLSPStudentas.SelectedItem.ToString()).Key);
                if (exsistingStudent != null)
                {
                    btnConfirmUpdateStudentas.Show();
                    btnConfirmUpdateStudentas.Text = "Patvirtinti";
                    btnConfirmUpdateStudentas.BackColor = Color.Green;
                    lblErrorStudent.Text = "Įveskite pakeitimus" + Environment.NewLine + "ir paspauskite patvirtinti";
                    cmbLSPStudentas.Enabled = false;
                    btnDeleteStudentas.Enabled = false;
                    btnAddStudentas.Enabled = false;
                    cmbFacultyStudentas.Enabled = false;
                }
            }
        }

        private void btnConfirmUpdateStudentas_Click(object sender, EventArgs e)
        {
            btnConfirmUpdateStudentas.Hide();
            cmbLSPStudentas.Enabled = true;
            btnDeleteStudentas.Enabled = true;
            btnAddStudentas.Enabled = true;
            cmbFacultyStudentas.Enabled = true;

            try
            {
                CheckStudentasInfo();
            }
            catch (Exception exc)
            {
                lblErrorStudent.Text = exc.Message;
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingStudent.Vardas = txtNameStudentas.Text;
                exsistingStudent.Pavarde = txtSurnameStudentas.Text;
                exsistingStudent.Gimimas = dtpBirthStudentas.Value;
                switch (cmbDegreeStudentas.SelectedIndex)
                {
                    case 0:
                        exsistingStudent.Kursas = 1;
                        exsistingStudent.Pakopa = "Bakalauras";
                        break;
                    case 1:
                        exsistingStudent.Kursas = 2;
                        exsistingStudent.Pakopa = "Bakalauras";
                        break;
                    case 2:
                        exsistingStudent.Kursas = 3;
                        exsistingStudent.Pakopa = "Bakalauras";
                        break;
                    case 3:
                        exsistingStudent.Kursas = 4;
                        exsistingStudent.Pakopa = "Bakalauras";
                        break;
                    case 4:
                        exsistingStudent.Kursas = 1;
                        exsistingStudent.Pakopa = "Magistras";
                        break;
                    case 5:
                        exsistingStudent.Kursas = 2;
                        exsistingStudent.Pakopa = "Magistras";
                        break;
                }

                db.Entry(exsistingStudent).State = System.Data.Entity.EntityState.Modified;

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
                        ex.Entries.Single().Reload();
                    }

                } while (saveFailed);

            }
            lblErrorStudent.Text = "Pakeista";
            UpdateLSPStudentas();
        }

        private void btnDeleteStudentas_Click(object sender, EventArgs e)
        {
            if (cmbLSPStudentas.SelectedIndex == 0)
            {
                lblErrorStudent.Text = "Pirma pasirinkite Destytoją";
                return;
            }

            using (var db = new UniversityContext())
            {
                exsistingStudent = db.Studentas.Find(StudentLSPs.FirstOrDefault(x => x.Value == cmbLSPStudentas.SelectedItem.ToString()).Key);
                if (exsistingStudent != null)
                {
                    db.Studentas.Remove(exsistingStudent);
                    lblErrorStudent.Text = "Ištrinta";
                    db.SaveChanges();
                }
            }
            UpdateLSPStudentas();
        }
    }
}
