using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using static System.Net.WebRequestMethods;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Dhondt
{
    /// <summary>
    /// 
    /// </summary>
    class Szimulacio
    {
        
        private int nemszav = 0;
        private string filepath;
        private static Random r = new Random();
        private char[] abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private string[] szazalek = new string[3] {"5","10","15"};

        //konstruktor
        public Szimulacio(string filepath)
        {
            this.filepath = filepath;
        }


        public void SecondRun(DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            sz.Atfordit();
            SecondTablaKiir(dataGridView, sz.p);
        }

        public void SecondTablaKiir(DataGridView dataGridView, Partok p)
        {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            int n = MandatumCount(k).Sum(x => x.Value);
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.ColumnCount = n+1;
            dataGridView.Columns[0].Name = "";
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.MultiSelect = false;

            for (int i = 1; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Name = $"{i}.";
            }



            foreach (var part in p.Parts)
            {
                List<object> rowData = new List<object> { part.PartNev };

                foreach (var elem in part.oszlop)
                {
                    rowData.Add(elem.Item1);
                }

                int rowIndex = dataGridView.Rows.Add(rowData.ToArray());

                for (int i = 1; i < dataGridView.ColumnCount; i++)
                {
                    bool isTrue = part.oszlop[i - 1].Item2;
                    if (isTrue)
                    {
                        dataGridView.Rows[rowIndex].Cells[i].Style.BackColor = Color.LightBlue;
                    }
                }
            }
            dataGridView.ScrollBars = ScrollBars.None;
            
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Height = ((dataGridView.Height - 13) / p.Partszam - 1);
                MessageBox.Show(((dataGridView.Height - 13) / p.Partszam - 1).ToString());
            }

            for (int i = 0; i < dataGridView.ColumnCount; ++i) {
                dataGridView.Columns[i].Width = (dataGridView.Width + 1) / (n+1);
            }
            dataGridView.KeyDown += dataGridView_KeyDown;

        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private Dictionary<string, int> MandatumCount(List<(int, string)> k) => k.GroupBy(item => item.Item2).ToDictionary(group => group.Key, group => group.Count());

        public bool Ellenoriz()=>System.IO.File.ReadLines(filepath).Count()-1 <= 15;
        public string SzavazatSzam() {
            Szamol sz = new Szamol(filepath);
            return sz.p.Parts.Sum(x => x.SzavazatSzam).ToString();
        }
        public string MandSzam() {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            return MandatumCount(k).Sum(x=> x.Value).ToString();
        }
        public string NyertMandArany() {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            return ((double)MandatumCount(k).Max(x => x.Value) / MandatumCount(k).Sum(x => x.Value) *100).ToString();
        }
        public string Partszam() {
            Szamol sz = new Szamol(filepath);
            return sz.p.Partszam.ToString();
        }
        public string NyertNev()
        {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            int maxInt = k.Max(tuple => tuple.Item1);
            var maxTuple = k.First(tuple => tuple.Item1 == maxInt);
            return maxTuple.Item2;
        }
        public string NyertSzavSzam() {
            Szamol sz = new Szamol(filepath);
            return sz.p.Parts.Max(x => x.SzavazatSzam).ToString();
        }
        public void MandatumAranyDiagram(Chart c)
        {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> m = sz.MandatumKioszt().GroupBy(x => x.Item2).Select(group => (group.Sum(x => x.Item1), group.Key)).ToList();
            for (int i = 0; i < m.Count; ++i){
                c.Series[$"Series1"].Points.AddXY($"{m[i].Item2}", m[i].Item1);
            }
            
        }
        public void SzavazatiAranyDiagram(Chart c) { 
            Szamol sz = new Szamol(filepath);
            for (int i = 0; i < sz.p.Parts.Count; ++i)
            {
                c.Series[$"Series1"].Points.AddXY($"{sz.p.Parts[i].PartNev}", sz.p.Parts[i].SzavazatSzam);
            
            }
        }

        public void SzavazatokEsPartok(Chart c) {
            Szamol sz = new Szamol(filepath);
            for (int i = 0; i < sz.p.Parts.Count; ++i)
            {
                c.Series["Series1"].Points.AddXY($"{sz.p.Parts[i].PartNev}", sz.p.Parts[i].SzavazatSzam);
            }
        }

        public void General(int partszam,int mandatumszam,int nemszavazott,int szavazokszama) {
            int nullaz = 0;
            int min = (int)szavazokszama / 400;
            int max = (int)szavazokszama / 100;
            nemszav = nemszavazott;
            StreamWriter w = new StreamWriter("gen.txt");
            w.WriteLine(mandatumszam);
            szavazokszama -= nemszav;
            for(int i=0; i < partszam; ++i)
            {
                if (nullaz < 2)
                {
                    if (r.Next(0, 2) == 1)
                    {
                        w.WriteLine(string.Concat("Part", abc[i], " ", r.Next(0, 2), " ", 0, " ", szazalek[r.Next(0, 3)]));
                        nullaz++;
                    }
                    else
                    {
                        int szavazata = szavazokszama - r.Next(min, max);
                        szavazokszama -= szavazata;
                        w.WriteLine(string.Concat("Part", abc[i], " ", r.Next(0, 2), " ", szavazata, " ", szazalek[r.Next(0, 3)]));
                    }
                }
                else { 
                    int szavazata = szavazokszama - r.Next(min, max);
                    szavazokszama -= szavazata;
                    w.WriteLine(string.Concat("Part", abc[i], " ", r.Next(0, 2), " ", szavazata, " ", szazalek[r.Next(0, 3)]));

                }
            }
            w.Close();
        }

        
    }



}