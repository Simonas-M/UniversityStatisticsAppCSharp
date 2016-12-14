using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
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

        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        DataSet tables = new DataSet();

        public MainWindow()
        {
            InitializeComponent();

            tables.Tables.Add("Fakultetas");
            tables.Tables.Add("Destytojas");
            tables.Tables.Add("Dalykas");
            tables.Tables.Add("Studentas");

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

            string query = "SELECT * FROM [dbo].[Fakultetas]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            tables.Tables["Fakultetas"].Clear();
            adapter.Fill(tables, "Fakultetas");

            DataTable faculties = tables.Tables["Fakultetas"];
            dataGrid.DataSource = faculties;
        }

        private void btnDestotojai_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGrid.Show();

            string query = "SELECT * FROM [dbo].[Destytojas]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            tables.Tables["Destytojas"].Clear();
            adapter.Fill(tables, "Destytojas");

            DataTable lecturers = tables.Tables["Destytojas"];
            dataGrid.DataSource = lecturers;
        }

        private void btnStudentai_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGrid.Show();

            string query = "SELECT * FROM [dbo].[Studentas]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            tables.Tables["Studentas"].Clear();
            adapter.Fill(tables, "Studentas");

            DataTable student = tables.Tables["Studentas"];
            dataGrid.DataSource = student;
        }

        private void btnDalykai_Click(object sender, EventArgs e)
        {
            HideAll();
            dataGrid.Show();

            string query = "SELECT * FROM [dbo].[Dalykas]";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            tables.Tables["Dalykas"].Clear();
            adapter.Fill(tables, "Dalykas");

            DataTable course = tables.Tables["Dalykas"];
            dataGrid.DataSource = course;
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

            chart.ChartAreas[0].AxisX.MaximumAutoSize = 100;
            using (var db = new UniversityContext())
            {
                switch (cmbX.SelectedIndex)
                {
                    case 0://Dalykas
                        switch(cmbY.SelectedIndex)
                        {
                            case 0://Dalykas
                                return;
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
                                return;
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
                                return;
                        }
                        break;
                }
                chart.ChartAreas[0].AxisX.Maximum = chart.Series[0].Points.Count+0.5;
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
                chart.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            EditWindow edit = new EditWindow();
            edit.ShowDialog();
        }
    }
}
