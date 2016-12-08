using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UniversitySQL
{
    public partial class MainWindow : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private short VUcounter = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.chart.ChartAreas["ChartArea1"].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            dataGrid.Hide();
            chart.Hide();
            lblX.Hide();
            lblY.Hide();
            cmbX.Hide();
            cmbY.Hide();
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
            HideAll();
            dataGrid.Show();
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
            }
        }

        private void btnDestotojai_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGrid.Show();
            using (var db = new UniversityContext())
            {
                var query = from a in db.Destytojas
                            select a;

                var listas = query.ToList();

                dataGrid.Rows.Clear();
                dataGrid.Columns.Clear();
                dataGrid.Refresh();


                dataGrid.Columns.Add("AK", "AK");
                dataGrid.Columns.Add("Fakultetas", "Fakultetas");
                dataGrid.Columns.Add("Vardas", "Vardas");
                dataGrid.Columns.Add("Pavarde", "Pavarde");
                dataGrid.Columns.Add("Laipsnis", "Laipsnis");

                for (int i = 0; i < listas.Count; i++)
                {
                    dataGrid.Rows.Add(listas[i].Asmens_Kodas, listas[i].Fakultetas, listas[i].Vardas, listas[i].Pavarde, listas[i].Laipsnis);
                }
            }
        }

        private void btnStudentai_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGrid.Show();
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
            HideAll();
            dataGrid.Show();
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

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            HideAll();
            chart.Show();
            lblX.Show();
            lblY.Show();
            cmbX.Show();
            cmbY.Show();


            cmbX.SelectedIndex = 0;
            cmbY.SelectedIndex = 1;
            DrawChart();

            cmbX.SelectedIndexChanged += ((send, args) =>
            {
                DrawChart();
            });
            cmbY.SelectedIndexChanged += ((send, args) =>
            {
                DrawChart();
            });
        }

        private void HideAll()
        {
            dataGrid.Hide();
            chart.Hide();
            lblX.Hide();
            lblY.Hide();
            cmbX.Hide();
            cmbY.Hide();
        }

        private Legend legend(string title)
        {
            Legend legend = new Legend(title);
            legend.BackColor = ColorTranslator.FromHtml("#7986CB");
            legend.Docking = Docking.Bottom;
            return legend;
        }

        private Series series(string title)
        {
            Series series = new Series(title);
            series.Color = ColorTranslator.FromHtml("#E91E63");
            series.BorderWidth = 2;
            series.BorderColor = ColorTranslator.FromHtml("#F48FB1");
            return series;
        }

        private void DrawChart()
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();
            using (var db = new UniversityContext())
            {
                switch (cmbX.SelectedIndex)
                {
                    case 0://Dalykas
                        switch(cmbY.SelectedIndex)
                        {
                            case 0://Dalykas
                                chart.Titles.Add("Sorry No Can DO!");
                                chart.Titles[0].Font = new Font("Trajan Pro", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                                break;
                            case 1://Destytojas
                                chart.Series.Add(series("Dėstytojas"));
                                chart.Legends.Add(legend("Dėstytojas"));
                                var query0 = from a in db.Destytojas
                                            select a;
                                foreach (var item in query0)
                                {
                                    chart.Series["Dėstytojas"].Points.AddXY(item.Vardas + " " + item.Pavarde, item.Dalykas.Count);
                                }
                                break;
                            case 2://Fakultetas
                                chart.Series.Add(series("Fakultetas"));
                                chart.Legends.Add(legend("Fakultetas"));
                                var query1 = from a in db.Fakultetas
                                            select a;
                                foreach (var item in query1)
                                {
                                    int kiekis = 0;
                                    foreach (var dalykas in item.Destytojas)
                                    {
                                        if (dalykas.Fakultetas == item.Pavadinimas)
                                            kiekis++;
                                    }
                                    chart.Series["Fakultetas"].Points.AddXY(item.Pavadinimas, kiekis);
                                }
                                break;
                            case 3://Studentas
                                chart.Series.Add(series("Studentas"));
                                chart.Legends.Add(legend("Studentas"));
                                var query2 = from a in db.Studentas
                                             select a;
                                foreach (var item in query2)
                                {
                                    if(item.Dalykas.Count != 0)
                                        chart.Series["Studentas"].Points.AddXY(item.Vardas + " " + item.Pavarde, item.Dalykas.Count);
                                }
                                break;
                        }
                        break;
                    case 1://Destytojas
                        switch (cmbY.SelectedIndex)
                        {
                            case 0://Dalykas
                                chart.Series.Add(series("Dalykas"));
                                chart.Legends.Add(legend("Dalykas"));
                                var query0 = from a in db.Dalykas
                                             select a;
                                foreach (var item in query0)
                                {
                                    chart.Series["Dalykas"].Points.AddXY(item.Pavadinimas, item.Destytojas.Count);
                                }
                                break;
                            case 1://Destytojas
                                //Negalimas
                                break;
                            case 2://Fakultetas
                                chart.Series.Add(series("Fakultetas"));
                                chart.Legends.Add(legend("Fakultetas"));
                                var query1 = from a in db.Fakultetas
                                             select a;
                                foreach (var item in query1)
                                {
                                    chart.Series["Fakultetas"].Points.AddXY(item.Pavadinimas, item.Destytojas.Count);
                                }
                                break;
                            case 3://Studentas
                                chart.Series.Add(series("Studentas"));
                                chart.Legends.Add(legend("Studentas"));
                                var query2 = from a in db.Studentas
                                             select a;
                                foreach (var item in query2)
                                {
                                    int kiekis = 0;
                                    foreach (var dalykas in item.Dalykas)
                                    {
                                        kiekis += dalykas.Destytojas.Count;
                                    }
                                    if (item.Dalykas.Count != 0)
                                        chart.Series["Studentas"].Points.AddXY(item.Vardas + " " + item.Pavarde, kiekis);
                                }
                                break;
                        }
                        break;
                    case 2://Studentas
                        switch (cmbY.SelectedIndex)
                        {
                            case 0://Dalykas
                                chart.Series.Add(series("Dalykas"));
                                chart.Legends.Add(legend("Dalykas"));
                                var query0 = from a in db.Dalykas
                                             select a;
                                foreach (var item in query0)
                                {
                                    chart.Series["Dalykas"].Points.AddXY(item.Pavadinimas, item.Studentas.Count);
                                }
                                break;
                            case 1://Destytojas
                                chart.Series.Add(series("Destytojas"));
                                chart.Legends.Add(legend("Destytojas"));
                                var query1 = from a in db.Studentas
                                             select a;
                                foreach (var item in query1)
                                {
                                    int kiekis = 0;
                                    foreach (var dalykas in item.Dalykas)
                                    {
                                        kiekis += dalykas.Studentas.Count;
                                    }
                                    if (item.Dalykas.Count != 0)
                                        chart.Series["Destytojas"].Points.AddXY(item.Vardas + " " + item.Pavarde, kiekis);
                                }
                                break;
                            case 2://Fakultetas
                                chart.Series.Add(series("Fakultetas"));
                                chart.Legends.Add(legend("Fakultetas"));
                                var query2 = from a in db.Fakultetas
                                             select a;
                                foreach (var item in query2)
                                {
                                    chart.Series["Fakultetas"].Points.AddXY(item.Pavadinimas, item.Studentas.Count);
                                }
                                break;
                            case 3://Studentas
                                //Negalimas
                                break;
                        }
                        break;
                }
            }
            //using (var db = new UniversityContext())
            //{
            //    var query = from a in db.Fakultetas
            //                select a;
            //    chart.Series.Add("Fakultetas");
            //    foreach (var item in query)
            //    {
            //        chart.Series["Fakultetas"].Points.AddXY(item.Pavadinimas, item.Destytojas.Count);
            //    }
            //}
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            EditWindow edit = new EditWindow();
            edit.ShowDialog();
        }
    }
}
