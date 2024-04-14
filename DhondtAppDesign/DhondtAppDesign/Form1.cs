using Dhondt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            bok.Enabled = false;
            btorol.Enabled = false;
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
                bok.Enabled = true;
                bgeneral.Enabled = false;
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
        NumericUpDown nuszavszam = new NumericUpDown();
        NumericUpDown nunemszav = new NumericUpDown();
        NumericUpDown numandatumszam = new NumericUpDown();
        NumericUpDown numapartszam = new NumericUpDown();
        Panel pBeallitasok = new Panel();
        private void bgeneral_Click(object sender, EventArgs e)
        {
            nuszavszam = new NumericUpDown();
            nunemszav = new NumericUpDown();
            numandatumszam = new NumericUpDown();
            numapartszam = new NumericUpDown();

            pBeallitasok = new Panel();
            pBeallitasok.Height = this.Height;
            pBeallitasok.Width = this.Width;
            pBeallitasok.BackColor = Color.White;
            this.Controls.Add(pBeallitasok);
            pBeallitasok.BringToFront();

           

            
            nuszavszam.Maximum = 9999999;
            nuszavszam.Minimum = 30000;
            nuszavszam.Location = new Point(310, 20);
            nuszavszam.Font = new Font("Arial", 20);
            nuszavszam.Width = 200;
            Label lszavszam = new Label();
            lszavszam.Text = "Emberek száma:";
            lszavszam.Location = new Point(10, 20);
            lszavszam.BackColor = Color.Transparent;
            lszavszam.Height = 40;
            lszavszam.Font = new Font("Arial",20);
            lszavszam.Width = 300;

            pBeallitasok.Controls.Add(lszavszam);
            pBeallitasok.Controls.Add(nuszavszam);

          
            nunemszav.Maximum = nuszavszam.Value / 2;
            nunemszav.Minimum = 0;
            nunemszav.Location = new Point(310, 60);
            nunemszav.Font = new Font("Arial", 20);
            nunemszav.Width=200;
            Label lnemszav = new Label();
            lnemszav.Text = "Nem szavazók száma:";
            lnemszav.Location = new Point(10, 60);
            lnemszav.BackColor = Color.Transparent;

            lnemszav.Font = new Font("Arial", 20);
            lnemszav.Height = 40;
            lnemszav.Width = 300;

            pBeallitasok.Controls.Add(lnemszav);
            pBeallitasok.Controls.Add(nunemszav);

            
            numandatumszam.Maximum = 15;
            numandatumszam.Minimum = 7;
            numandatumszam.Location = new Point(310, 100);
            numandatumszam.Font = new Font("Arial", 20);
            numandatumszam.Width = 200;
            Label lmandatumszam = new Label();
            lmandatumszam.Text = "Mandátumok száma:";
            lmandatumszam.Location = new Point(10, 100);
            lmandatumszam.BackColor = Color.Transparent;
            lmandatumszam.Height = 40;
            lmandatumszam.Width = 300;
            lmandatumszam.Font = new Font("Arial", 20);

            pBeallitasok.Controls.Add(lmandatumszam);
            pBeallitasok.Controls.Add(numandatumszam);

            
            numapartszam.Maximum = 20;
            numapartszam.Minimum = 2;
            numapartszam.Location = new Point(310, 140);
            numapartszam.Font = new Font("Arial", 20);
            numapartszam.Width= 200;
            Label lmapartszam = new Label();
            lmapartszam.Text = "Pártok száma:";
            lmapartszam.Location = new Point(10, 140);
            lmapartszam.BackColor = Color.Transparent;
            lmapartszam.Height = 40;
            lmapartszam.Font = new Font("Arial", 20);
            lmapartszam.Width =300;

            pBeallitasok.Controls.Add(lmapartszam);
            pBeallitasok.Controls.Add(numapartszam);

            Button bgen = new Button();
            bgen.Text = "Generálás";
            bgen.Location = new Point(10, 180);
            bgen.Width = 501;
            bgen.Height = 60;
            bgen.Click += Gen;
            pBeallitasok.Controls.Add(bgen);
        }
        void Gen(object o, EventArgs e) {
            Szimulacio sz = new Szimulacio("gen.txt");
            sz.General(int.Parse(numapartszam.Value.ToString()),int.Parse(numandatumszam.Value.ToString()),int.Parse(nunemszav.Value.ToString()),int.Parse(nuszavszam.Value.ToString()));
            lszavazatszam.Text = sz.SzavazatSzam();
            lmandatumszam.Text = sz.MandSzam();
            lnyertmandarany.Text = sz.NyertMandArany() + "%";
            lnyertesnev.Text = sz.NyertNev();
            lpartokszama.Text = sz.Partszam();
            lnyertszavszam.Text = sz.NyertSzavSzam();
            lnemszavazott.Text = sz.Nemszav();
            sz.MandatumAranyDiagram(cmandatumok);
            sz.SzavazatiAranyDiagram(cszavaranydiag);
            sz.SzavazatokEsPartok(cszavazatespart);
            sz.SecondRun(dgvmatrix);
            btorol.Enabled = true;
            bok.Enabled = false;
            bgeneral.Enabled = false;
            bfilekivalaszt.Enabled = false;
            pBeallitasok.Dispose();
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
            lnemszavazott.Text = sz.Nemszav();
            sz.MandatumAranyDiagram(cmandatumok);
            sz.SzavazatiAranyDiagram(cszavaranydiag);
            sz.SzavazatokEsPartok(cszavazatespart);
            btorol.Enabled = true;
            bok.Enabled = false;
            bgeneral.Enabled = false;
            bfilekivalaszt.Enabled = false;
            //lnyertszavszam.Text = sz.NyertSzavSzam();
            
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
            cmandatumok.Series["Series1"].Points.Clear();
            cszavaranydiag.Series["Series1"].Points.Clear();
            cszavazatespart.Series["Series1"].Points.Clear();
            hasznaltFile = "";
            dgvmatrix.Rows.Clear();
            dgvmatrix.DataSource = null;
            dgvmatrix.Refresh();
            dgvmatrix.Columns.Clear();
            bgeneral.Enabled = true;
            bfilekivalaszt.Enabled = true;
        }

        private void lnyertszavszam_Click(object sender, EventArgs e)
        {

        }
    }
}
