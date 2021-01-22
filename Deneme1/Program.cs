using System;

namespace Deneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs ();
            kurs1.KursAdi = "CSharp";
            kurs1.Egitmeni = "Eren Yozgat";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Eren Yozgat";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni = "Eren Yozgat";
            kurs3.IzlenmeOrani = 100;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            

            Arkadas arkadas1 = new Arkadas ();
            arkadas1.Adi = "Erdinç";
            arkadas1.Yasi = 23;
            arkadas1.Memleketi = "Bolu olduğunu iddia ediyor ama Sivas";

            Arkadas arkadas2 = new Arkadas();
            arkadas2.Adi = "Yasin";
            arkadas2.Yasi = 23;
            arkadas2.Memleketi = "Sinop";

            Arkadas arkadas3 = new Arkadas();
            arkadas3.Adi = "Eren";
            arkadas3.Yasi = 22;
            arkadas3.Memleketi = "Manhattan";

            Arkadas arkadas4 = new Arkadas();
            arkadas4.Adi = "Deniz";
            arkadas4.Yasi = 22;
            arkadas4.Memleketi = "Kürt";


            Arkadas[] arkadaslar = new Arkadas[] { arkadas1, arkadas2, arkadas3, arkadas4 };

            foreach (Arkadas arkadas in arkadaslar)
            {
                Console.WriteLine(arkadas.Adi);
                Console.WriteLine(arkadas.Yasi);
                Console.WriteLine(arkadas.Memleketi);
            }
        
        
        
        
        
        
        }


    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }


    class Arkadas
    {
        public string Adi { get; set; }

        public int Yasi { get; set; }

        public string Memleketi { get; set; }
    }
}

