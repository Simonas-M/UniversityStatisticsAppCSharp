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
    public partial class MainWindow : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public MainWindow()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#3F51B5");
            pnlRight.BackColor = ColorTranslator.FromHtml("#7986CB");
            pnlCenter.BackColor = ColorTranslator.FromHtml("#7986CB");
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFakultetai_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                var query = from a in db.Fakultetas
                                        select a;

                var listas = query.ToList();

                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();


                dataGrid.Columns.Add("Pavadinimas", "Pavadinimas");
                dataGrid.Columns.Add("Adresas", "Adresas");
                dataGrid.Columns.Add("Telefono_Nr", "Telefono_Nr");

                for (int i = 0; i < listas.Count; i++)
                {
                    dataGrid.Rows.Add(listas[i].Pavadinimas, listas[i].Adresas, listas[i].Telefono_Nr);
                }
                //dataGrid.DataSource = dt;
            }
        }

        private void btnDestotojai_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                var query = from a in db.Destytojas
                            select a;

                var listas = query.ToList();

                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();


                dataGrid.Columns.Add("AK", "AK");
                dataGrid.Columns.Add("Vardas", "Vardas");
                dataGrid.Columns.Add("Pavarde", "Pavarde");
                dataGrid.Columns.Add("Laipsnis", "Laipsnis");

                for (int i = 0; i < listas.Count; i++)
                {
                    dataGrid.Rows.Add(listas[i].Asmens_Kodas, listas[i].Vardas, listas[i].Pavarde, listas[i].Laipsnis);
                }
            }
        }

        private void btnStudentai_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                var query = from a in db.Studentas
                            select a;

                var listas = query.ToList();

                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();


                dataGrid.Columns.Add("LSP", "LSP");
                dataGrid.Columns.Add("Vardas", "Vardas");
                dataGrid.Columns.Add("Pavarde", "Pavarde");
                dataGrid.Columns.Add("Gimimas", "Gimimas");
                dataGrid.Columns.Add("Pakopa", "Pakopa");
                dataGrid.Columns.Add("Kursas", "Kursas");

                for (int i = 0; i < listas.Count; i++)
                {
                    dataGrid.Rows.Add(listas[i].LSP_Nr, listas[i].Vardas, listas[i].Pavarde, listas[i].Gimimas.ToShortDateString(), listas[i].Pakopa, listas[i].Kursas);
                }
            }
        }

        private void btnDalykai_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityContext())
            {
                var query = from a in db.Dalykas
                            select a;

                var listas = query.ToList();

                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();


                dataGrid.Columns.Add("ID", "ID");
                dataGrid.Columns.Add("Pavadinimas", "Pavadinimas");
                dataGrid.Columns.Add("Kreditu_Skaicius", "Kreditu_Skaicius");

                for (int i = 0; i < listas.Count; i++)
                {
                    dataGrid.Rows.Add(listas[i].ID, listas[i].Pavadinimas, listas[i].Kreditu_Sk);
                }
            }
        }
    }
}
