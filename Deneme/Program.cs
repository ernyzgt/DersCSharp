using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Rainbow char1 = new Rainbow ;
            char1.Adi = "zero";
            char1.Ozellik = "kamera";
            char1.Silahı = "assault";


            Rainbow[] isim = new Rainbow { char1 };


            foreach (Rainbow isimler in isim);
            {
                Console.WriteLine(isim.Adi);
                Console.WriteLine(isim.Ozellik);
                Console.WriteLine(isim.Silahı);
            }

           
        }
    }
    class Rainbow
    {
        public string Adi { get; set; }

        public string Ozellik { get; set; }

        public string Silahı { get; set; }

    }
}

