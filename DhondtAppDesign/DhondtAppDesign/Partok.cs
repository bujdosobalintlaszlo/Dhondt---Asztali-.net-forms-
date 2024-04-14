using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Dhondt
{
    /// <summary>
    /// Ebből az osztályból érhető el az a lista amely az összes pártot magábafoglalja.
    /// Emellett elérhető a pártszám(Partszam) és a mandátumszám(Mandatum) is.
    /// </summary>
    class Partok
    {
        //Az összes párt egy listában
        public List<Part> Parts { get; set; }
        //pártszám gettere
        public int Partszam
        {
            get
            {
                return Parts.Count;
            }
        }
        private static int mandatum;
        public int nemszavazott;
        //mandátum gettere
        public static int Mandatum
        {
            get
            {
                return mandatum;
            }
        }

        //konstruktor
        public Partok()
        {
            Parts = new List<Part>();
        }

        /// <summary>
        /// Sor alapján inicializálja a Partok objektumot.
        /// </summary>
        /// <param name="sor">A sor, amelyből inicializáljuk a Partok objektumot.</param>
        public Partok(string fajlNev)
        {
            List<string> lines = File.ReadAllLines(fajlNev).ToList();
            List<string> firstLineValues = lines[0].Split(',').ToList();
            mandatum = Convert.ToInt32(firstLineValues[0]);
            nemszavazott = Convert.ToInt32(firstLineValues[1]);
            //mandatum = Convert.ToInt32(File.ReadAllLines(fajlNev).Take(1).First());
            //nemszavazott = Convert.ToInt32(File.ReadAllLines(fajlNev).Take(2));
            Parts = File.ReadAllLines(fajlNev).Skip(1).Select(sor => new Part(sor)).ToList();
        }
    }
}