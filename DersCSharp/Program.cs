using System;

namespace DersCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Kendini tekrar etme
            //String = Değer tutucu, Alias
            //Değişken tamamlamanın amacı herhangi bir
            //değiştirme sonrası teker teker uğraşmamak


            string kategoriEtiketi = "Kategori";
            // Belli bir kapasitesi var
            int ogrenciSayisi = 32000;

            //Float
            double faizOrani = 1.45;

            //Şart kalıbı True False
            //Javada boolean
            bool sistemeGirisYapmisMi = false;


            double dolanDun = 7.35;
            double dolarBugun = 7.45;



            if (dolanDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolanDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("Değişim Yok");
            }




            // iki tab bu şartı oluşturur
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi)




        }
    }
}
