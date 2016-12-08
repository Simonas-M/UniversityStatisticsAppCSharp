using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public EditWindow()
        {
            InitializeComponent();
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
                if (txtTitle.Text.Length > 38)
                {
                    txtTitle.BackColor = Color.Salmon;
                    throw new ArgumentException("Pavadinimas negali buti" + Environment.NewLine + "ilgesnis negu 38 simboliai");
                }
                else if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    txtTitle.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtTitle.Text);
                }
                else if (txtAddress.Text.Length > 38)
                {
                    txtAddress.BackColor = Color.Salmon;
                    throw new ArgumentException("Adresas negali buti" + Environment.NewLine + "ilgesnis negu 38 simboliai");
                }

                else if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    txtAddress.BackColor = Color.Salmon;
                    throw new ArgumentNullException(txtAddress.Text);
                }

                else if (!new System.Text.RegularExpressions.Regex(@"^\+370\d{8}$").IsMatch(txtPhoneNr.Text))
                {
                    txtPhoneNr.BackColor = Color.Salmon;
                    throw new ArgumentException("Telefono numeris" + Environment.NewLine + "turi buti +370...");
                }

            }
            catch (Exception exc)
            {
                lblError.Text = exc.Message;
                return;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckFakultetasInfo();            

            using (var db = new UniversityContext())
            {
                Fakultetas faculty = new Fakultetas();
                faculty.Pavadinimas = txtTitle.Text;
                faculty.Adresas = txtAddress.Text;
                faculty.Telefono_Nr = txtPhoneNr.Text;

                db.Fakultetas.Add(faculty);
                db.SaveChanges();
            }
        }

        private void btnUpdateFakultetas_Click(object sender, EventArgs e)
        {
            CheckFakultetasInfo();

            using (var db = new UniversityContext())
            {
                Fakultetas faculty = new Fakultetas();
                faculty.Pavadinimas = txtTitle.Text;
                faculty.Adresas = txtAddress.Text;
                faculty.Telefono_Nr = txtPhoneNr.Text;

                foreach (var fakultetas in db.Fakultetas)
                {
                    if(fakultetas.Pavadinimas == faculty.Pavadinimas)
                    {
                        btnUpdateFakultetas.BackColor = Color.Green;
                        break;
                    }
                }
                Fakultetas exsisting = db.Fakultetas.Find(faculty.Pavadinimas);
            }
        }
    }
}
