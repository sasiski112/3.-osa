using System;
using System.Collections.Generic;
using System.Text;

namespace _3._osa
{
    internal class StartPage
    {
        public static void Main()
        {
             
            while (true)
            {
                Console.WriteLine("\n=== MENÜÜ ===");
                Console.WriteLine("1 - Juhuslike arvude ruudud");
                Console.WriteLine("2 - Viie arvu analüüs");
                Console.WriteLine("3 - Nimed ja vanused");
                Console.WriteLine("4 - Osta elevant ära!");
                Console.WriteLine("5 - Arvamise mäng");
                Console.WriteLine("6 - Suurim neliarvuline arv");
                Console.WriteLine("7 - Korrutustabel");
                Console.WriteLine("8 - Õpilastega mängimine");
                Console.WriteLine("9 - Arvude ruudud");
                Console.WriteLine("10 - Positiivsed ja negatiivsed");
                Console.WriteLine("11 - Keskmisest suuremad");
                Console.WriteLine("12 - Kõige suurema arvu otsing");
                Console.WriteLine("13 - Paari- ja paaritud loendused");
                Console.WriteLine("0 - Välju");
                string valik = Console.ReadLine();
                switch (valik)
                {
                    case "1": Console.Clear(); Funktsioonid.Ruudud(); break;
                    case "2": Console.Clear(); Funktsioonid.KäivitaAnalüüs(); break;
                    case "3": Console.Clear(); Funktsioonid.Inimesed(); break;
                    case "4": Console.Clear(); Funktsioonid.Märksõna(); break;
                    case "5": Console.Clear(); Funktsioonid.ArvaArv(); break;
                    case "6": Console.Clear(); Funktsioonid.SuurimArv(); break;
                    case "7": Console.Clear(); Funktsioonid.Korrutustabel(); break;
                    case "8": Console.Clear(); Funktsioonid.Tudengid(); break;
                    case "9": Console.Clear(); Funktsioonid.ArvRud(); break;
                    case "10": Console.Clear(); Funktsioonid.PositivneNegativne(); break;
                    case "11": Console.Clear(); Funktsioonid.Keskmine(); break;
                    case "12": Console.Clear(); Funktsioonid.KõigeSuurem(); break;
                    case "13": Console.Clear(); Funktsioonid.PaariLoendused(); break;
                    case "0": return;
                    default: Console.WriteLine("Vale valik"); break;
                }
            }
        }
    }
}
