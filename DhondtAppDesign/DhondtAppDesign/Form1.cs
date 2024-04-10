using Dhondt;
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

namespace DhondtAppDesign
{
    public partial class Form1 : Form
    {
        private string hasznaltFile = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "D'hondt app";
            lfilenev.Enabled = false;
            lfilenev.Font = new Font("Microsoft Sans Serif", 12);
            lfilenev.Height = 60;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bfilekivalaszt_Click(object sender, EventArgs e) {
            lfilenev.ForeColor = Color.Black;
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lfilenev.Text = ofd.SafeFileName;
                hasznaltFile = ofd.FileName;
            }
            else {
                lfilenev.Text = "Hibás file!";
                lfilenev.ForeColor = Color.Red;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lszavszam_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            
        }

        private void bgeneral_Click(object sender, EventArgs e)
        {
            Panel pBeallitasok = new Panel();
            pBeallitasok.Height = this.Height;
            pBeallitasok.Width = this.Width;
            pBeallitasok.BackColor = Color.White;
            this.Controls.Add(pBeallitasok);
            pBeallitasok.BringToFront();

            TextBox tszavazok = new TextBox();
            pBeallitasok.Controls.Add(tszavazok);




        }

        private void bok_Click(object sender, EventArgs e)
        {
            Szimulacio sz = new Szimulacio(hasznaltFile);
            if (sz.Ellenoriz())
            {
                sz.SecondRun(dgvmatrix);
            }
            else {
                lfilenev.Text = "Hibás file!";
                lfilenev.ForeColor = Color.Red;
            }
            lszavazatszam.Text = sz.SzavazatSzam();
            lmandatumszam.Text = sz.MandSzam();
            lnyertmandarany.Text = sz.NyertMandArany()+"%";
            lnyertesnev.Text = sz.NyertNev();
            lpartokszama.Text = sz.Partszam();
            lnyertszavszam.Text = sz.NyertSzavSzam();
            sz.MandatumAranyDiagram(cmandatumok);
            sz.SzavazatiAranyDiagram(cszavaranydiag);
            sz.SzavazatokEsPartok(cszavazatespart);
            //lnyertszavszam.Text = sz.NyertSzavSzam();
            //dgvmatrix
        }

        private void btorol_Click(object sender, EventArgs e)
        {
            lszavazatszam.Text = "0";
            lmandatumszam.Text = "0";
            lnyertmandarany.Text = "0";
            lnyertesnev.Text = "-";
            lpartokszama.Text = "0";
            lnemszavazott.Text = "0";
            lfilenev.Text = "Üres";
            lnyertszavszam.Text = "0";
            cmandatumok.Series.Clear();
            cszavaranydiag.Series.Clear();
            cszavazatespart.Series.Clear();
            hasznaltFile = "";
            dgvmatrix.Rows.Clear();
            dgvmatrix.DataSource = null;
            dgvmatrix.Refresh();
        }

        private void lnyertszavszam_Click(object sender, EventArgs e)
        {

        }
    }
}
