using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuvar
{
    internal class Program
    {
        private static List<Fuvar> fuvarok = new List<Fuvar>();
        private static List<Fuvar> hibak = new List<Fuvar>();
        private static int db1, db2, db3, db4, db5 = 0;
        private static double tav = 0;
        private static string fejlec;
        static void Main(string[] args)
        {
            fajlbeolvas();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();

            Console.ReadLine();
        }

        private static void feladat8()
        {
            Console.Write("8. feladat: hibak.txt");



            for (int i = 0; i < fuvarok.Count; i++)
            {
                if (fuvarok[i].UtazasIdo > 0 && fuvarok[i].VitelDij > 0 && fuvarok[i].MegtettTav == 0)
                {
                    // hibak.Add(new Fuvar(fuvarok[i].TaxiAzonosito, fuvarok[i].IndulásIdo, fuvarok[i].UtazasIdo, fuvarok[i].MegtettTav, fuvarok[i].VitelDij, fuvarok[i].Borravalo, fuvarok[i].FizetesMod));
                    hibak.Add(fuvarok[i]);
                }
            }

            List<Fuvar> rendezett = hibak.OrderBy(x => x.IndulásIdo).ToList();

            FileStream fajlnev = new FileStream(@"hibak.txt", FileMode.Create);
            StreamWriter iras = new StreamWriter(fajlnev, Encoding.UTF8);

            iras.WriteLine(fejlec);

            for (int i = 0; i < rendezett.Count; i++)
            {
                iras.Write($"{rendezett[i].TaxiAzonosito};");
                iras.Write($"{rendezett[i].IndulásIdo};");
                iras.Write($"{rendezett[i].UtazasIdo};");
                iras.Write($"{rendezett[i].MegtettTav};");
                iras.Write($"{rendezett[i].VitelDij};");
                iras.Write($"{rendezett[i].Borravalo};");
                iras.Write($"{rendezett[i].FizetesMod}\n");
            }

            iras.Close();
            fajlnev.Close();

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void feladat7()
        {
            Console.WriteLine("7. feladat: Leghosszabb fuvar: ");

            int azonosito = 0;
            double megtettTav = 0;
            double vitelDij = 0;

            int max = 0;
            int maxi = fuvarok[max].UtazasIdo;

            for (int i = 0; i < fuvarok.Count; i++)
            {
                while (maxi < fuvarok[i].UtazasIdo)
                {
                    maxi = fuvarok[i].UtazasIdo;
                }

                if (fuvarok[i].UtazasIdo == maxi)
                {
                    azonosito = fuvarok[i].TaxiAzonosito;
                    megtettTav = fuvarok[i].MegtettTav;
                    vitelDij = fuvarok[i].VitelDij;
                }
            }

            

            Console.WriteLine($"\tFuvar hossza: {maxi} másodperc");
            Console.WriteLine($"\tTaxi azonosító: {azonosito}");
            Console.WriteLine($"\tMegtett távolság: {megtettTav}km");
            Console.WriteLine($"\tViteldíj: {vitelDij}$");

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void feladat6()
        {
            Console.Write("6. feladat: ");

            for (int i = 0; i < fuvarok.Count; i++)
            {
                tav += fuvarok[i].MegtettTav;
            }

            double km = tav * 1.6;

            Console.WriteLine($"{Math.Round(km, 2)}km");

            Console.WriteLine();
        }

        private static void feladat5()
        {
            Console.WriteLine("5. feladat: ");

            
            for (int i = 0; i < fuvarok.Count; i++)
            {
                switch (fuvarok[i].FizetesMod)
                {
                    case "bankkártya":
                        db1++;
                        break;

                    case "készpénz":
                        db2++;
                        break;

                    case "vitatott":
                        db3++;
                        break;

                    case "ingyenes":
                        db4++;
                        break;

                    case "ismeretlen":
                        db5++;
                        break;
                }
            }

            Console.WriteLine($"\tbankkártya: {db1}");
            Console.WriteLine($"\tkészpénz: {db2}");
            Console.WriteLine($"\tvitatott: {db3}");
            Console.WriteLine($"\tingyenes: {db4}");
            Console.WriteLine($"\tismeretlen: {db5}");

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void feladat4()
        {
            Console.Write("4. feladat: ");

            double bevetel = 0;
            int fuvarSzam = 0;

            for (int i = 0; i < fuvarok.Count; i++)
            {
                if (fuvarok[i].TaxiAzonosito == 6185)
                {
                    bevetel += fuvarok[i].VitelDij;
                    fuvarSzam++;
                }
            }

            Console.WriteLine($"{fuvarSzam} alatt: {bevetel}$");


            Console.WriteLine();
        }

        private static void feladat3()
        {
            /*
            Console.Write("\n3. feladat: ");

            int utazasDb = 0;

            for (int i = 0; i <= fuvarok.Count; i++)
            {
                utazasDb = i;
            }

            Console.Write($"{utazasDb} fuvar");
            */
            
            Console.Write("\n3. feladat: {0}", fuvarok.Count);

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void fajlbeolvas()
        {
            StreamReader beolvas = new StreamReader(@"fuvar.csv");
            fejlec = beolvas.ReadLine();
            while (!beolvas.EndOfStream)
            {
                string sor = beolvas.ReadLine();
                string[] sorElem = sor.Split(';');
                fuvarok.Add(new Fuvar(int.Parse(sorElem[0]), sorElem[1], int.Parse(sorElem[2]), double.Parse(sorElem[3]), double.Parse(sorElem[4]), double.Parse(sorElem[5]), sorElem[6]));
            }
        }
    }
}
