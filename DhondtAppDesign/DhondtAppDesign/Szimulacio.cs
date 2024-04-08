using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace Dhondt
{
    /// <summary>
    /// 
    /// </summary>
    class Szimulacio
    {
        //számontartja, hogy hanyadik pártot generálja
        private int counter = 1;
        private string filepath;
        private static Random r = new Random();

        //konstruktor
        public Szimulacio(string filepath)
        {
            this.filepath = filepath;
        }

        /// <summary>
        /// Kigenerálja a pártoknak a számát 15 és 100 között
        /// </summary>
        /// <returns>Visszatér a pártszámmal.</returns>
        private int PartSzamGeneral() => r.Next(15, 100);

        /// <summary>
        /// Kigenerálja a mandátumok számát a pártszám figyelembe vételével.
        /// </summary>
        /// <returns>Visszatér a mandátumszámmal.</returns>
        private int MandatumGeneral() => PartSzamGeneral() > 50 ? PartSzamGeneral() * 3 : PartSzamGeneral() * 2;


        /// <summary>
        /// Lefuttatja azokat a függvényeket amikre szükségünk van a Console-on való megjelenítéshez.
        /// </summary>
        public void FirstRun(DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            FirstTableKiir(dataGridView, sz.p);
        }

        public void SecondRun(DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            sz.Atfordit();
            SecondTablaKiir(dataGridView, sz.p);
        }

        /// <summary>
        /// Azokból a szavazatszámokból amelyek sok szavazatot kapnak 1/5 eséllyel megtolja a szavazatjainak a számát.
        /// </summary>
        /// <returns>Visszatér egy igaz hamis értékkel.</returns>
        /// 
        private bool NagySzavazatuMegtol() => r.Next(1, 101) < 5 ? true : false;

        /// <summary>
        /// Eldönti, hogy nagyobb szavazat szám legyen vagy kisebb.
        /// </summary>
        /// <returns>Visszatér egy igaz hamis értékkel.</returns>
        private bool GeneralElsoResz() => r.Next(1, 16) < 15 ? false : true;

        /// <summary>
        /// A mandátum számot beleírja a fájlba + Egy sort ír a fájlba.
        /// </summary>
        /// <param name="n">indexelés</param>
        /// <param name="partSzam">Pártszám</param>
        /// <param name="mandatumSzam">MandátumSzám</param>
        private void SorbaIr(int n, int partSzam, int mandatumSzam)
        {
            using (StreamWriter w = new StreamWriter($"inp{n}.txt"))
            {
                List<int> szazalekok = new List<int>() { 5, 10, 15 };
                w.WriteLine(mandatumSzam);
                for (int i = 1; i <= partSzam; i++)
                {
                    bool elsoResz = GeneralElsoResz();
                    bool nagySzavazatu = NagySzavazatuMegtol();

                    int randomNumber;
                    if (nagySzavazatu)
                    {
                        randomNumber = r.Next(5000000, 10000000);
                    }
                    else
                    {
                        randomNumber = r.Next(0, 200000);
                    }

                    int index = elsoResz ? (nagySzavazatu ? r.Next(1, 3) : r.Next(1, 3)) : r.Next(0, 2);

                    w.WriteLine($"Párt{i} {r.Next(0, 2)} {randomNumber} {szazalekok[index]}");
                }
            }
        }


        /// <summary>
        /// Összetartja a Generálási folyamatot, itt fut le egybe.
        /// </summary>
        /// <param name="db">Mennyiszer fusson le</param>
        /// <param name="partSzam">PartSzám</param>
        /// <param name="mandatumSzam">Mandátumszám</param>
        private void GeneralMasodikResz(int db, int partSzam, int mandatumSzam)
        {
            int n = 1;
            while (n <= db)
            {
                SorbaIr(n, partSzam, mandatumSzam);
                n++;
            }
        }


        private void FirstTableKiir(DataGridView dataGridView, Partok p)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Pártok";
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Columns[1].Name = "Szavazatok száma";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowHeadersVisible = false;
            foreach (var part in p.Parts)
            {
                dataGridView.Rows.Add(part.PartNev, part.SzavazatSzam);
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SecondTablaKiir(DataGridView dataGridView, Partok p)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.ColumnCount = p.Parts.Count + 1;
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
                        dataGridView.Rows[rowIndex].Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        public void ThirdTableKiir(ref DataGridView dataGridView1)
        {
            Szamol sz = new Szamol(filepath);
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("PartColumn", "Párt");
            dataGridView1.Columns.Add("MandateColumn", "Mandátumok");

            List<(int, string)> k = sz.Cserelget();
            List<(string, int)> orderedData = RendezettAdatok(HarmadikTablaDictionary(k));

            foreach (var entry in orderedData)
            {
                dataGridView1.Rows.Add(entry.Item1, entry.Item2);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private List<(string, int)> RendezettAdatok(Dictionary<string, int> dic)
        {
            List<(string, int)> result = dic.Select(pair => (pair.Key, pair.Value)).ToList();
            result.Sort();
            return result;
        }

        private Dictionary<string, int> HarmadikTablaDictionary(List<(int, string)> l)
        {
            Dictionary<string, int> partEsMandatum = new Dictionary<string, int>();
            foreach (var elem in l)
            {
                string temp = elem.Item2;

                if (partEsMandatum.ContainsKey(temp))
                {
                    partEsMandatum[temp]++;
                }
                else
                {
                    partEsMandatum[temp] = 1;
                }
            }
            return partEsMandatum;
        }

        public void FourthTable(ref DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            int ossz = SzavazatokSum(sz.p);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Columns.Add("PartNevColumn", "Párt");
            dataGridView.Columns.Add("SzavazatSzamColumn", "Szavazatok aránya");

            foreach (var part in sz.p.Parts)
            {
                double szavazatArany = Math.Round((double)part.SzavazatSzam / ossz * 100, 1);
                dataGridView.Rows.Add(part.PartNev, $"{szavazatArany}%");
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private int SzavazatokSum(Partok p) => p.Parts.Sum(x => x.SzavazatSzam);

        public void FifthTableKiir(ref DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            List<string> partok = EgyediPartok(k);

            List<(string, int)> partEsSzavszam = PartEsSzavszamFeltolt(partok, sz.p);

            int osszeg = BejutottakSzavazatSum(partEsSzavszam);

            dataGridView.Columns.Add("PartNevColumn", "Párt");
            dataGridView.Columns.Add("SzavazatSzamColumn", "Szavazatok aránya");
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Dock = DockStyle.Fill;
            foreach (var entry in partEsSzavszam)
            {
                double szavazatArany = Math.Round((double)entry.Item2 / osszeg * 100);
                dataGridView.Rows.Add(entry.Item1, $"{szavazatArany}%");
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private int BejutottakSzavazatSum(List<(string, int)> k) => k.Sum(x => x.Item2);

        private List<string> EgyediPartok(List<(int, string)> k) => k.Select(x => x.Item2).Distinct().ToList();

        private List<(string, int)> PartEsSzavszamFeltolt(List<string> l, Partok p)
        {
            List<(string, int)> partEsSzavszam = new List<(string, int)>();
            l.ForEach(x =>
            {
                var part = p.Parts.FirstOrDefault(y => y.PartNev == x);
                if (part != null && part.oszlop.Count > 0 && part.oszlop[0].Item1 != null)
                {
                    int szam = Convert.ToInt32(part.oszlop[0].Item1);
                    partEsSzavszam.Add((x, szam));
                }
            });
            return partEsSzavszam;
        }
        public void SixthTableKiir(ref DataGridView dataGridView)
        {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            Dictionary<string, int> PartEsMandatumSzam = MandatumCount(k);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Columns.Add("PartNevColumn", "Párt");
            dataGridView.Columns.Add("MandatumSzamColumn", "Mandátumok aránya");
            foreach (var item in PartEsMandatumSzam)
            {
                double arany = Math.Round((double)item.Value / Partok.Mandatum * 100, 1);
                dataGridView.Rows.Add(item.Key, $"{arany}%");
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private Dictionary<string, int> MandatumCount(List<(int, string)> k) => k.GroupBy(item => item.Item2).ToDictionary(group => group.Key, group => group.Count());

        public bool Ellenoriz()=>System.IO.File.ReadLines(filepath).Count()-1 <= 10;
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

        public string NyertNev() {
            Szamol sz = new Szamol(filepath);
            List<(int, string)> k = sz.Cserelget();
            return "Meg nem mukodik";
        }
    }



}