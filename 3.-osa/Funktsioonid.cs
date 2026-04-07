using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._osa
{
    internal class Funktsioon
    {
        // 1. Ruudud
        public static void Ruudud()
        {
            Random r = new Random();
            int a = r.Next(1, 10);
            int b = r.Next(1, 10);

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            for (int i = min; i <= max; i++)
                Console.WriteLine($"{i} - {i * i}");
        }

        // 2. KäivitaAnalüüs
        public static void KäivitaAnalüüs()
        {
            Console.WriteLine("Sisesta arvud (ruumiga eraldatud):");

            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Tühi sisend!");
                return;
            }

            string[] osad = input.Split();
            List<double> arvud = new List<double>();

            foreach (var s in osad)
            {
                if (double.TryParse(s, out double x))
                    arvud.Add(x);
                else
                    Console.WriteLine($"Vale arv: {s}");
            }

            if (arvud.Count == 0)
            {
                Console.WriteLine("Pole ühtegi korrektset arvu!");
                return;
            }

            var t = Analüüsi(arvud.ToArray());
            Console.WriteLine($"Summa: {t.Summa}");
            Console.WriteLine($"Keskmine: {t.Keskmine}");
            Console.WriteLine($"Korrutis: {t.Korrutis}");
        }

        static (double Summa, double Keskmine, double Korrutis) Analüüsi(double[] a)
        {
            double s = a.Sum();
            double k = a.Average();
            double korr = 1;
            foreach (var x in a) korr *= x;
            return (s, k, korr);
        }

        // 3. Inimesed
        class Inimene
        {
            public string Nimi;
            public int Vanus;
        }

        public static void Inimesed()
        {
            Console.WriteLine("Sisesta 5 inimest:");
            List<Inimene> list = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();

                int vanus;
                while (true)
                {
                    Console.Write("Vanus: ");
                    if (int.TryParse(Console.ReadLine(), out vanus) && vanus > 0)
                        break;
                    Console.WriteLine("Vale vanus! Proovi uuesti.");
                }

                list.Add(new Inimene { Nimi = nimi, Vanus = vanus });
            }

            Console.WriteLine($"Keskmine vanus: {list.Average(x => x.Vanus)}");
            var vanim = list.OrderByDescending(x => x.Vanus).First();
            var noorim = list.OrderBy(x => x.Vanus).First();
            Console.WriteLine($"Vanim: {vanim.Nimi}, Noorim: {noorim.Nimi}");
        }

        // 4. Märksõna
        public static void Märksõna()
        {
            List<string> list = new List<string>();
            string s;

            do
            {
                Console.WriteLine("Osta elevant");
                Console.Write("Sisesta: ");
                s = Console.ReadLine();
                list.Add(s);
            } while (s != "stop");

            Console.WriteLine("Sisestatud sõnad:");
            foreach (var x in list) Console.WriteLine(x);
        }

        // 5. ArvaArv
        public static void ArvaArv()
        {
            Console.WriteLine("Arva number 1–100 (5 katset)");
            Random r = new Random();
            int arv = r.Next(1, 101);

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sinu arv: ");
                if (!int.TryParse(Console.ReadLine(), out int g))
                {
                    Console.WriteLine("Vale sisend! Sisesta arv.");
                    i--; // ei loe katset
                    continue;
                }

                if (g == arv)
                {
                    Console.WriteLine("Õige!");
                    return;
                }
                else if (g > arv)
                    Console.WriteLine("Liiga suur");
                else
                    Console.WriteLine("Liiga väike");
            }

            Console.WriteLine($"Õige oli {arv}");
        }

        // 6. SuurimArv
        public static void SuurimArv()
        {
            Console.WriteLine("Sisesta 4 numbrit (ruumiga eraldatud):");
            string[] sisend = Console.ReadLine().Split();
            if (sisend.Length != 4)
            {
                Console.WriteLine("Peab olema 4 arvu!");
                return;
            }

            int[] a = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(sisend[i], out a[i]))
                {
                    Console.WriteLine("Vale arv!");
                    return;
                }
            }

            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine("Järjestatud suurimast väiksemani: " + string.Join(" ", a));
        }

        // 7. Korrutustabel
        public static void Korrutustabel()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.Write((i * j).ToString().PadLeft(4));
                Console.WriteLine();
            }
        }

        // 8. Tudengid
        public static void Tudengid()
        {
            List<string> n = new List<string>
            { "Andres","Mari","Jaan","Kati","Peeter","Liis","Anne","Karl","Ain","Mati" };

            n[2] = "Kati"; // muutmine
            n[5] = "Mati";

            Console.WriteLine("Nimed, mis algavad A-tähega:");
            foreach (var x in n.Where(x => x.StartsWith("A")))
                Console.WriteLine(x);

            Console.WriteLine("Kõik nimed indeksitega:");
            for (int j = 0; j < n.Count; j++)
                Console.WriteLine($"{j}: {n[j]}");

            Console.WriteLine("Kõik nimed väikeste tähtedega:");
            foreach (var x in n)
                Console.WriteLine(x.ToLower());

            Console.WriteLine("Väljasta kuni 'Mati':");
            int k = 0;
            do
            {
                Console.WriteLine(n[k]);
            } while (n[k++] != "Mati" && k < n.Count);
        }

        // 9. ArvRud
        public static void ArvRud()
        {
            int[] a = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine("Iga ruut:");
            foreach (var x in a)
                Console.WriteLine(x * x);

            Console.WriteLine("Iga arv kahekordne:");
            foreach (var x in a)
                Console.WriteLine(x * 2);

            int count3 = a.Count(x => x % 3 == 0);
            Console.WriteLine($"Arvud, mis jaguvad 3-ga: {count3}");
        }

        // 10. PositivneNegativne
        public static void PositivneNegativne()
        {
            int[] a = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int p = a.Count(x => x > 0);
            int n = a.Count(x => x < 0);
            int z = a.Count(x => x == 0);

            Console.WriteLine($"Pos:{p} Neg:{n} Zero:{z}");
        }

        // 11. Keskmine
        public static void Keskmine()
        {
            Random r = new Random();
            int[] a = new int[15];

            for (int i = 0; i < 15; i++)
                a[i] = r.Next(1, 101);

            double avg = a.Average();
            Console.WriteLine($"Keskmine: {avg}");

            Console.WriteLine("Suuremad kui keskmine:");
            foreach (var x in a.Where(x => x > avg))
                Console.WriteLine(x);

            int i2 = 0;
            do
            {
                Console.WriteLine(a[i2]);
            } while (a[i2++] >= 10 && i2 < a.Length);
        }

        // 12. KõigeSuurem
        public static void KõigeSuurem()
        {
            int[] a = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = a.Max();
            int idx = Array.IndexOf(a, max);

            Console.WriteLine($"Max: {max} Index: {idx}");
        }

        // 13. PaariLoendused
        public static void PaariLoendused()
        {
            Random r = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
                list.Add(r.Next(1, 101));

            int sumE = list.Where(x => x % 2 == 0).Sum();
            var oddList = list.Where(x => x % 2 != 0).ToList();
            double avgO = oddList.Count > 0 ? oddList.Average() : 0;
            int c50 = list.Count(x => x > 50);

            Console.WriteLine($"Even sum: {sumE}, Odd avg: {avgO}, >50: {c50}");
        }
    }
}
