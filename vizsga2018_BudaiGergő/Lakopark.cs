    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga2018_BudaiGergő
{
    internal class Lakopark
    {

        int[,] Hazak;
        string nev;
        int utcakSzama;
        int maxHazSzam;

        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public int[,] Hazak1 { get => Hazak; set => Hazak = value; }

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            Hazak = hazak;
        }
    

    }
}
