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
    public partial class TaughtCoursesForm : Form
    {
        private Dictionary<string, string> lecturerAKs;
        private Dictionary<Guid, string> courseIDs = new Dictionary<Guid, string>();

        public TaughtCoursesForm(Dictionary<string, string> lecturerAKs)
        {
            InitializeComponent();

            this.lecturerAKs = lecturerAKs;

            InitializeLecturers();
            InitializeCourses();
        }

        private void InitializeCourses()
        {
            cmbCourses.Items.Clear();
            courseIDs.Clear();
            using (var db = new UniversityContext())
            {
                var query = from a in db.Dalykas
                            select a;
                foreach (var item in query)
                {
                    if(item.Destytojas.Count == 0)
                        cmbCourses.Items.Add(item.Pavadinimas);
                    courseIDs.Add(item.ID, item.Pavadinimas);
                }
                if (cmbCourses.Items.Count != 0)
                    cmbCourses.SelectedIndex = 0;
            }
        }

        private void InitializeLecturers()
        {
            foreach (var item in lecturerAKs.Skip(1))
            {
                cmbAKLecturer.Items.Add(item.Value);
                cmbLecturerDelete.Items.Add(item.Value);
            }
            cmbAKLecturer.SelectedIndex = 0;
            cmbLecturerDelete.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                Destytojas lecturer = db.Destytojas.Find(lecturerAKs.FirstOrDefault(x => x.Value == cmbAKLecturer.SelectedItem.ToString()).Key);
                Dalykas course = db.Dalykas.Find(courseIDs.FirstOrDefault(x => x.Value == cmbCourses.SelectedItem.ToString()).Key);

                lecturer.Dalykas.Add(course);
                db.Entry(lecturer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            lblErrorRegister.Text = "Atlikta";
            InitializeCourses();
        }

        private void cmbLecturerDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLecturerCourses.Items.Clear();
            using (var db = new UniversityContext())
            {
                Destytojas selectedLecturer = db.Destytojas.Find(lecturerAKs.FirstOrDefault(x => x.Value == cmbLecturerDelete.SelectedItem.ToString()).Key);
                var query = from a in db.Dalykas
                            select a;
                foreach (var course in query)
                {
                    if (course.Destytojas.Contains(selectedLecturer))
                        cmbLecturerCourses.Items.Add(course.Pavadinimas);
                }
            }
            if (cmbLecturerCourses.Items.Count != 0)
                cmbLecturerCourses.SelectedIndex = 0;
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                Destytojas lecturer = db.Destytojas.Find(lecturerAKs.FirstOrDefault(x => x.Value == cmbLecturerDelete.SelectedItem.ToString()).Key);
                Dalykas course = db.Dalykas.Find(courseIDs.FirstOrDefault(x => x.Value == cmbLecturerCourses.SelectedItem.ToString()).Key);

                lecturer.Dalykas.Remove(course);
                db.Entry(lecturer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            lblErrorUnregister.Text = "Atlikta!";
            InitializeCourses();
        }
    }
}
