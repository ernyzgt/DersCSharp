﻿using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Eren";
            int yas = 22;
            
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 78;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Eren Yozgat";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 32;


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmeni);
                Console.WriteLine(kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
