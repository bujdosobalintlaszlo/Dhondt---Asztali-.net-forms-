
namespace DhondtAppDesign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lnev = new System.Windows.Forms.Label();
            this.bfilekivalaszt = new System.Windows.Forms.Button();
            this.lfilenev = new System.Windows.Forms.TextBox();
            this.bgeneral = new System.Windows.Forms.Button();
            this.btorol = new System.Windows.Forms.Button();
            this.bok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lszavazatszam = new System.Windows.Forms.Label();
            this.lszavszam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnemszav = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lmandatum = new System.Windows.Forms.Label();
            this.lmandatumszam = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lpartszam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lnyertes = new System.Windows.Forms.Label();
            this.lnyertesnev = new System.Windows.Forms.Label();
            this.nyertesszavsz = new System.Windows.Forms.Panel();
            this.lnyertesszavszam = new System.Windows.Forms.Label();
            this.lnyertszavszam = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.larany = new System.Windows.Forms.Label();
            this.lnyertmandarany = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvmatrix = new System.Windows.Forms.DataGridView();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.nyertesszavsz.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lnev
            // 
            this.lnev.AutoSize = true;
            this.lnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnev.Location = new System.Drawing.Point(-1, 2);
            this.lnev.Name = "lnev";
            this.lnev.Size = new System.Drawing.Size(169, 51);
            this.lnev.TabIndex = 2;
            this.lnev.Text = "D\'hondt";
            this.lnev.Click += new System.EventHandler(this.label1_Click);
            // 
            // bfilekivalaszt
            // 
            this.bfilekivalaszt.Location = new System.Drawing.Point(175, 3);
            this.bfilekivalaszt.Name = "bfilekivalaszt";
            this.bfilekivalaszt.Size = new System.Drawing.Size(167, 49);
            this.bfilekivalaszt.TabIndex = 3;
            this.bfilekivalaszt.Text = "File kiválasztása";
            this.bfilekivalaszt.UseVisualStyleBackColor = true;
            this.bfilekivalaszt.Click += new System.EventHandler(this.bfilekivalaszt_Click);
            // 
            // lfilenev
            // 
            this.lfilenev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lfilenev.Location = new System.Drawing.Point(3, 41);
            this.lfilenev.Name = "lfilenev";
            this.lfilenev.Size = new System.Drawing.Size(272, 26);
            this.lfilenev.TabIndex = 4;
            this.lfilenev.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bgeneral
            // 
            this.bgeneral.Location = new System.Drawing.Point(348, 3);
            this.bgeneral.Name = "bgeneral";
            this.bgeneral.Size = new System.Drawing.Size(168, 49);
            this.bgeneral.TabIndex = 5;
            this.bgeneral.Text = "Generálás";
            this.bgeneral.UseVisualStyleBackColor = true;
            this.bgeneral.Click += new System.EventHandler(this.bgeneral_Click);
            // 
            // btorol
            // 
            this.btorol.Location = new System.Drawing.Point(678, 3);
            this.btorol.Name = "btorol";
            this.btorol.Size = new System.Drawing.Size(160, 49);
            this.btorol.TabIndex = 6;
            this.btorol.Text = "Törlés";
            this.btorol.UseVisualStyleBackColor = true;
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(522, 3);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(150, 49);
            this.bok.TabIndex = 7;
            this.bok.Text = "Ok";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lszavazatszam);
            this.panel1.Controls.Add(this.lszavszam);
            this.panel1.Location = new System.Drawing.Point(33, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lszavazatszam
            // 
            this.lszavazatszam.AutoSize = true;
            this.lszavazatszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lszavazatszam.Location = new System.Drawing.Point(3, 42);
            this.lszavazatszam.Name = "lszavazatszam";
            this.lszavazatszam.Size = new System.Drawing.Size(108, 25);
            this.lszavazatszam.TabIndex = 10;
            this.lszavazatszam.Text = "10000000";
            // 
            // lszavszam
            // 
            this.lszavszam.AutoSize = true;
            this.lszavszam.BackColor = System.Drawing.Color.Transparent;
            this.lszavszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lszavszam.Location = new System.Drawing.Point(-3, 0);
            this.lszavszam.Name = "lszavszam";
            this.lszavszam.Size = new System.Drawing.Size(99, 17);
            this.lszavszam.TabIndex = 9;
            this.lszavszam.Text = "Szavazatszám";
            this.lszavszam.Click += new System.EventHandler(this.lszavszam_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lnemszav);
            this.panel2.Location = new System.Drawing.Point(254, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "10000000";
            // 
            // lnemszav
            // 
            this.lnemszav.AutoSize = true;
            this.lnemszav.BackColor = System.Drawing.Color.White;
            this.lnemszav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lnemszav.Location = new System.Drawing.Point(3, 0);
            this.lnemszav.Name = "lnemszav";
            this.lnemszav.Size = new System.Drawing.Size(101, 17);
            this.lnemszav.TabIndex = 11;
            this.lnemszav.Text = "Nem szavazott";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(641, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lmandatum);
            this.panel3.Controls.Add(this.lmandatumszam);
            this.panel3.Location = new System.Drawing.Point(478, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 12;
            // 
            // lmandatum
            // 
            this.lmandatum.AutoSize = true;
            this.lmandatum.BackColor = System.Drawing.Color.White;
            this.lmandatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lmandatum.Location = new System.Drawing.Point(0, 0);
            this.lmandatum.Name = "lmandatum";
            this.lmandatum.Size = new System.Drawing.Size(74, 17);
            this.lmandatum.TabIndex = 13;
            this.lmandatum.Text = "Mandátum";
            // 
            // lmandatumszam
            // 
            this.lmandatumszam.AutoSize = true;
            this.lmandatumszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lmandatumszam.Location = new System.Drawing.Point(13, 42);
            this.lmandatumszam.Name = "lmandatumszam";
            this.lmandatumszam.Size = new System.Drawing.Size(108, 25);
            this.lmandatumszam.TabIndex = 10;
            this.lmandatumszam.Text = "10000000";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lpartszam);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(700, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 14;
            // 
            // lpartszam
            // 
            this.lpartszam.AutoSize = true;
            this.lpartszam.BackColor = System.Drawing.Color.White;
            this.lpartszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lpartszam.Location = new System.Drawing.Point(0, 0);
            this.lpartszam.Name = "lpartszam";
            this.lpartszam.Size = new System.Drawing.Size(67, 17);
            this.lpartszam.TabIndex = 13;
            this.lpartszam.Text = "Pártszám";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "10000000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lnyertes);
            this.panel5.Controls.Add(this.lnyertesnev);
            this.panel5.Location = new System.Drawing.Point(927, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 15;
            // 
            // lnyertes
            // 
            this.lnyertes.AutoSize = true;
            this.lnyertes.BackColor = System.Drawing.Color.White;
            this.lnyertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lnyertes.Location = new System.Drawing.Point(0, 0);
            this.lnyertes.Name = "lnyertes";
            this.lnyertes.Size = new System.Drawing.Size(86, 17);
            this.lnyertes.TabIndex = 13;
            this.lnyertes.Text = "Nyertes párt";
            // 
            // lnyertesnev
            // 
            this.lnyertesnev.AutoSize = true;
            this.lnyertesnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lnyertesnev.Location = new System.Drawing.Point(13, 42);
            this.lnyertesnev.Name = "lnyertesnev";
            this.lnyertesnev.Size = new System.Drawing.Size(76, 25);
            this.lnyertesnev.TabIndex = 10;
            this.lnyertesnev.Text = "Fidesz";
            // 
            // nyertesszavsz
            // 
            this.nyertesszavsz.BackColor = System.Drawing.Color.White;
            this.nyertesszavsz.Controls.Add(this.lnyertesszavszam);
            this.nyertesszavsz.Controls.Add(this.lnyertszavszam);
            this.nyertesszavsz.Location = new System.Drawing.Point(1151, 108);
            this.nyertesszavsz.Name = "nyertesszavsz";
            this.nyertesszavsz.Size = new System.Drawing.Size(200, 100);
            this.nyertesszavsz.TabIndex = 16;
            // 
            // lnyertesszavszam
            // 
            this.lnyertesszavszam.AutoSize = true;
            this.lnyertesszavszam.BackColor = System.Drawing.Color.White;
            this.lnyertesszavszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lnyertesszavszam.Location = new System.Drawing.Point(0, 0);
            this.lnyertesszavszam.Name = "lnyertesszavszam";
            this.lnyertesszavszam.Size = new System.Drawing.Size(158, 17);
            this.lnyertesszavszam.TabIndex = 13;
            this.lnyertesszavszam.Text = "Nyertes szavazatszáma";
            // 
            // lnyertszavszam
            // 
            this.lnyertszavszam.AutoSize = true;
            this.lnyertszavszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lnyertszavszam.Location = new System.Drawing.Point(13, 42);
            this.lnyertszavszam.Name = "lnyertszavszam";
            this.lnyertszavszam.Size = new System.Drawing.Size(108, 25);
            this.lnyertszavszam.TabIndex = 10;
            this.lnyertszavszam.Text = "10000000";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.larany);
            this.panel6.Controls.Add(this.lnyertmandarany);
            this.panel6.Location = new System.Drawing.Point(1379, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 17;
            // 
            // larany
            // 
            this.larany.AutoSize = true;
            this.larany.BackColor = System.Drawing.Color.White;
            this.larany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.larany.Location = new System.Drawing.Point(0, 0);
            this.larany.Name = "larany";
            this.larany.Size = new System.Drawing.Size(168, 17);
            this.larany.TabIndex = 13;
            this.larany.Text = "Nyertes szavazati aránya";
            // 
            // lnyertmandarany
            // 
            this.lnyertmandarany.AutoSize = true;
            this.lnyertmandarany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lnyertmandarany.Location = new System.Drawing.Point(13, 42);
            this.lnyertmandarany.Name = "lnyertmandarany";
            this.lnyertmandarany.Size = new System.Drawing.Size(73, 25);
            this.lnyertmandarany.TabIndex = 10;
            this.lnyertmandarany.Text = "75,4%";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lfilenev);
            this.panel7.Location = new System.Drawing.Point(1608, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 100);
            this.panel7.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "File név";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(908, 547);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(978, 432);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Választási eredmény";
            this.chart1.Titles.Add(title4);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dgvmatrix
            // 
            this.dgvmatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatrix.Location = new System.Drawing.Point(33, 238);
            this.dgvmatrix.Name = "dgvmatrix";
            this.dgvmatrix.Size = new System.Drawing.Size(857, 741);
            this.dgvmatrix.TabIndex = 21;
            // 
            // chart3
            // 
            chartArea5.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart3.Legends.Add(legend5);
            this.chart3.Location = new System.Drawing.Point(1412, 238);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(474, 290);
            this.chart3.TabIndex = 22;
            this.chart3.Text = "chart3";
            title5.Name = "Title1";
            title5.Text = "Választási arány";
            this.chart3.Titles.Add(title5);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(908, 238);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 2;
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(474, 290);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            title6.Name = "Title2";
            title6.Text = "Mandátum arány";
            this.chart2.Titles.Add(title6);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.btorol);
            this.panel8.Controls.Add(this.bok);
            this.panel8.Controls.Add(this.bgeneral);
            this.panel8.Controls.Add(this.bfilekivalaszt);
            this.panel8.Controls.Add(this.lnev);
            this.panel8.Location = new System.Drawing.Point(33, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1853, 55);
            this.panel8.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.dgvmatrix);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.nyertesszavsz);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Nyertes párt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.nyertesszavsz.ResumeLayout(false);
            this.nyertesszavsz.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lnev;
        private System.Windows.Forms.Button bfilekivalaszt;
        private System.Windows.Forms.TextBox lfilenev;
        private System.Windows.Forms.Button bgeneral;
        private System.Windows.Forms.Button btorol;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lszavszam;
        private System.Windows.Forms.Label lszavazatszam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lnemszav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lmandatum;
        private System.Windows.Forms.Label lmandatumszam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lpartszam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lnyertes;
        private System.Windows.Forms.Label lnyertesnev;
        private System.Windows.Forms.Panel nyertesszavsz;
        private System.Windows.Forms.Label lnyertesszavszam;
        private System.Windows.Forms.Label lnyertszavszam;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label larany;
        private System.Windows.Forms.Label lnyertmandarany;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvmatrix;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel8;
    }
}

