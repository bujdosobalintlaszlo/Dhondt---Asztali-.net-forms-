using System;
using System.Collections.Generic;
using System.Linq;

namespace Dhondt
{
    /// <summary>
    /// A pártot reprezentáló osztály, tárolja a párt nevét, nemzetét, szavazatszámát, bejutási küszöbének százalékát
	///és az oszlopon belül a hozzátartózó dhondt mátrix oszlopát..
    /// </summary>
    class Part
    {
        public string PartNev { get; }
        public int Nemzete { get; }
        public int SzavazatSzam { get; }
        public int Szazalek { get; }
        public List<(int, bool)> oszlop { get; }

        //A konstrultor megkap egy sort a fileból majd azt feldarabplja. Felhasználja az OszlopGen() függvényt is.
        public Part(string sor)
        {
            List<string> sorSplit = sor.Split(' ').ToList();
            PartNev = sorSplit[0];
            Nemzete = int.Parse(sorSplit[1]);
            SzavazatSzam = int.Parse(sorSplit[2]);
            Szazalek = int.Parse(sorSplit[3]);
            oszlop = OszlopGen();
        }
        public Part(string partNev, int nemzete, int szavazatSzam, int szazalek)
        {
            PartNev = partNev;
            Nemzete = nemzete;
            SzavazatSzam = szavazatSzam;
            Szazalek = szazalek;
        }

        //Feltölti az adott párt oszlopát a szavazatszámnak és a 1 mandátumig osztott számokkal. Mindegyik mellé
        //rendel egy false értéket ami a megjelenítésnél fontos. Ennek az értékét a Szamol class-ban az Atfordit()
        //metódus változtatja true-ra adott esetben.
        private List<(int, bool)> OszlopGen()
        {
            List<(int, bool)> oszlopa = new List<(int, bool)>();

            for (int j = 0; j < Partok.Mandatum; j++)
            {
                int szam = (int)Math.Round((double)SzavazatSzam / (j + 1), 0);
                oszlopa.Add((szam, false));
            }
            return oszlopa;
        }
    }

}