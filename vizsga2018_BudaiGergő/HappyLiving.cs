using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsga2018_BudaiGergő
{
    internal class HappyLiving
    {

        List<Lakopark> lakoparkok = new List<Lakopark>();
        internal List<Lakopark> Lakoparkok { get => lakoparkok; set => lakoparkok = value; }
        public HappyLiving(string filenev)
        {
            using (StreamReader sr = new StreamReader(filenev))
            {

                while (!sr.EndOfStream)
                {
                    string LakoparkNev = sr.ReadLine();
                    string[] sor = sr.ReadLine().Split(';');
                    int utcakSzama = Convert.ToInt32(sor[0]);
                    int hazakSzama = Convert.ToInt32(sor[1]);
                    int[,] hazak = new int[utcakSzama, hazakSzama];
                    string ujSor = string.Empty;
                    while ((ujSor = sr.ReadLine()) != "")
                    {

                        sor = ujSor.Split(';');
                        hazak[Convert.ToInt32(sor[0]) - 1, Convert.ToInt32(sor[1]) - 1] = Convert.ToInt32(sor[2]);

                    }

                    lakoparkok.Add(new Lakopark(LakoparkNev, utcakSzama, hazakSzama, hazak));
                }

            }
        }

    }
}
