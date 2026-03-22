using System;
using System.Collections.Generic;
using System.Text;

namespace _3._osa
{
    internal class Funktsioonid
    {
        // 1
        public static void Ruudud()
        {
            try
            {
                Random r = new Random();
                int a = r.Next(1, 10);
                int b = r.Next(1, 10);

                int min = Math.Min(a, b);
                int max = Math.Max(a, b);

                for (int i = min; i <= max; i++)
                    Console.WriteLine($"{i} → {i * i}");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 2
        public static void KäivitaAnalüüs()
        {
            try 
            { 
                Console.WriteLine("Sisesta arvud:");
                double[] arvud = Console.ReadLine().Split().Select(double.Parse).ToArray();

                var t = Analüüsi(arvud);
                Console.WriteLine($"Summa:{t.Summa} Keskmine:{t.Keskmine} Korrutis:{t.Korrutis}");
        } 
            catch (Exception e)
            { Console.WriteLine(e) ; }
}

        static (double Summa, double Keskmine, double Korrutis) Analüüsi(double[] a)
        {
            double s = a.Sum();
            double k = a.Average();
            double korr = 1;
            foreach (var x in a) korr *= x;
            return (s, k, korr);
        }

        // 3
        class Inimene
        {
            public string Nimi;
            public int Vanus;
        }
        public static void Inimesed()
        {
            Console.WriteLine("Kirjuta Nimi ja Vanus 5 inimeseid");
            try { 
            List<Inimene> list = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();
                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                list.Add(new Inimene { Nimi = nimi, Vanus = vanus });

            }

            var sum = list.Sum(x => x.Vanus);
            var avg = list.Average(x => x.Vanus);
            var max = list.OrderByDescending(x => x.Vanus).First();
            var min = list.OrderBy(x => x.Vanus).First();

            Console.WriteLine($"Sum:{sum} Avg:{avg}");
            Console.WriteLine($"Vanim:{max.Nimi} Noorim:{min.Nimi}");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }



        // 4
        public static void Märksõna()
        {
            try { 
            List<string> list = new List<string>();
            string s;

            do
            {
                    Console.WriteLine("Osta elevant");
                Console.Write("Sisesta: ");
                s = Console.ReadLine();
                list.Add(s);
            } while (s != "stop");

            foreach (var x in list) Console.WriteLine(x);
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 5
        public static void ArvaArv()
        {
            Console.WriteLine("Arva ära number vahemikus 1 kuni 100 viie katsega!");
            try { 
            Random r = new Random();
            int arv = r.Next(1, 100);

            for (int i = 0; i < 5; i++)
            {
                int g = int.Parse(Console.ReadLine());

                if (g == arv) { Console.WriteLine("Õige"); return; }
                else if (g > arv) Console.WriteLine("Liiga suur");
                else Console.WriteLine("Liiga väike");
            }
            Console.WriteLine($"Õige oli {arv}");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 6
        public static void SuurimArv()
        { try {
                Console.WriteLine("Sisesta 4 numbrit:");
                int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Array.Sort(a);
                Array.Reverse(a);

                Console.WriteLine(string.Join("", a));
            }
            catch (Exception e)
            { Console.WriteLine(e);
            } 
        }

        // 7
        public static void Korrutustabel()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.Write((i * j).ToString().PadLeft(4));
                Console.WriteLine();
            }
                Console.ReadLine();
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 8
        public static void Tudengid()
        {
            try
            {
                List<string> n = new List<string>
        { "Andres","Mari","Jaan","Kati","Peeter","Liis","Anne","Karl","Ain","Mati" };

            n[2] = "Kati";
            n[5] = "Mati";

            int i = 0;
            while (i < n.Count)
            {
                if (n[i].StartsWith("A"))
                    Console.WriteLine(n[i]);
                i++;
            }
                Console.WriteLine();
            for (int j = 0; j < n.Count; j++)
                Console.WriteLine($"{j}:{n[j]}");
                Console.WriteLine();
            foreach (var x in n)
                Console.WriteLine(x.ToLower());
                Console.WriteLine();
            int k = 0;
            do
            {
                Console.WriteLine(n[k]);
            } while (n[k++] != "Mati");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 9
        public static void ArvRud()
        {
            try { 
            int[] a = { 2, 4, 6, 8, 10, 12 };

            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i] * a[i]);

            foreach (var x in a)
                Console.WriteLine(x * 2);

            int c = 0, i2 = 0;
            while (i2 < a.Length)
            {
                if (a[i2] % 3 == 0) c++;
                i2++;
            }
            Console.WriteLine(c);
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 10
        public static void PositivneNegativne()
        {
            try { 
            int[] a = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int p = 0, n = 0, z = 0;

            foreach (var x in a)
            {
                if (x > 0) p++;
                else if (x < 0) n++;
                else z++;
            }

            Console.WriteLine($"Pos:{p} Neg:{n} Zero:{z}");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 11
        public static void Keskmine()
        {
            try { 
            Random r = new Random();
            int[] a = new int[15];

            for (int i = 0; i < 15; i++)
                a[i] = r.Next(1, 101);

            double avg = a.Average();
            Console.WriteLine(avg);

            foreach (var x in a)
                if (x > avg) Console.WriteLine(x);

            int i2 = 0;
            do
            {
                Console.WriteLine(a[i2]);
            } while (a[i2++] >= 10 && i2 < a.Length);
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 12
        public static void KõigeSuurem()
        {
            try
            {
                int[] a = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = a[0], idx = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    idx = i;
                }
            }

            Console.WriteLine($"Max:{max} Index:{idx}");
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // 13
        public static void PaariLoendused()
        {
            try { 
            Random r = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
                list.Add(r.Next(1, 101));

            int sumE = 0;
            for (int i = 0; i < list.Count; i++)
                if (list[i] % 2 == 0) sumE += list[i];

            int sumO = 0, countO = 0;
            foreach (var x in list)
                if (x % 2 != 0) { sumO += x; countO++; }

            double avgO = (double)sumO / countO;

            int c50 = 0, i2 = 0;
            while (i2 < list.Count)
            {
                if (list[i2] > 50) c50++;
                i2++;
            }

            Console.WriteLine($"Even:{sumE} OddAvg:{avgO} >50:{c50}");
                 } catch (Exception e)
            { Console.WriteLine(e) ; }
        }
    }
}