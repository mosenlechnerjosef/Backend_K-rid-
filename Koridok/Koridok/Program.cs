namespace Koridok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();
            #region 2. feladat
            using (var sr = new StreamReader("autoverseny.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var sorTomb = sr.ReadLine().Split(";");

                    versenyzok.Add(new Versenyzo(sorTomb[0], sorTomb[1], Convert.ToInt32(sorTomb[2]), sorTomb[3],TimeSpan.Parse(sorTomb[4]), Convert.ToInt32(sorTomb[5])));
                }
            }
            #endregion
            #region 3. feladat
            Console.WriteLine("3. feladat: " + versenyzok.Count);
            #endregion
            #region 4. feladat
            var versenyzo_szurt = versenyzok.Where(x => x.Nev == "Fürge Ferenc" && x.Palya == "Gran Prix Circuit" && x.Kör == 3).ToList();
            versenyzo_szurt.ForEach(x => Console.WriteLine("4. feladat: " + (x.Korido.Seconds + x.Korido.Minutes * 60) + " másodperc"));
            #endregion
            #region 5.feladat
            Console.WriteLine("5. feladat:");
            Console.WriteLine("Kérem egy versenyző nevét:");
            #endregion
            #region 6. feladat
            Console.Write("6. feladat: ");
            var versenyzo_nev = Console.ReadLine();
            var leggyorsabbKor = versenyzok.Where(x => x.Nev == versenyzo_nev).OrderBy(x => x.Korido).FirstOrDefault();
            if (leggyorsabbKor != null)
            {
                Console.Write(leggyorsabbKor.Palya + ", " + leggyorsabbKor.Korido);
            }
            else
            {
                Console.Write("Nincs ilyen versenyző az állományban");
            }
            #endregion



            
            Console.ReadKey();
        }
    }
}