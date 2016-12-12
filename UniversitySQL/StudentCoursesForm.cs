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
    public partial class StudentCoursesForm : Form
    {
        private Dictionary<string, string> studentLSPs;
        private Dictionary<Guid, string> courseIDs = new Dictionary<Guid, string>();

        public StudentCoursesForm(Dictionary<string, string> studentLSPs)
        {
            InitializeComponent();

            this.studentLSPs = studentLSPs;

            InitializeStudents();
            InitializeCourses();
        }

        private void InitializeCourses()
        {
            using (var db = new UniversityContext())
            {
                var query = from a in db.Dalykas
                            where a.Destytojas.Count != 0
                            select a;

                foreach (var item in query)
                {
                    cmbCourses.Items.Add(item.Pavadinimas);
                    courseIDs.Add(item.ID, item.Pavadinimas);
                }
                cmbCourses.SelectedIndex = 0;
            }
        }

        private void InitializeStudents()
        {
            foreach (var item in studentLSPs.Skip(1))
            {
                cmbLSPStudent.Items.Add(item.Value);
                cmbStudentDelete.Items.Add(item.Value);
            }
            cmbLSPStudent.SelectedIndex = 0;
            cmbStudentDelete.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                Studentas student = db.Studentas.Find(studentLSPs.FirstOrDefault(x => x.Value == cmbLSPStudent.SelectedItem.ToString()).Key);
                Dalykas course = db.Dalykas.Find(courseIDs.FirstOrDefault(x => x.Value == cmbCourses.SelectedItem.ToString()).Key);

                student.Dalykas.Add(course);
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            lblErrorRegister.Text = "Atlikta";
        }

        private void cmbStudentDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentCourses.Items.Clear();
            using (var db = new UniversityContext())
            {
                Studentas selectedStudent = db.Studentas.Find(studentLSPs.FirstOrDefault(x => x.Value == cmbStudentDelete.SelectedItem.ToString()).Key);
                var query = from a in db.Dalykas
                            select a;
                foreach (var course in query)
                {
                    if (course.Studentas.Contains(selectedStudent))
                        cmbStudentCourses.Items.Add(course.Pavadinimas);
                }
            }
            if(cmbStudentCourses.Items.Count != 0)
                cmbStudentCourses.SelectedIndex = 0;
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                Studentas student = db.Studentas.Find(studentLSPs.FirstOrDefault(x => x.Value == cmbStudentDelete.SelectedItem.ToString()).Key);
                Dalykas course = db.Dalykas.Find(courseIDs.FirstOrDefault(x => x.Value == cmbStudentCourses.SelectedItem.ToString()).Key);

                student.Dalykas.Remove(course);
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            lblErrorUnregister.Text = "Atlikta!";
        }
    }
}
