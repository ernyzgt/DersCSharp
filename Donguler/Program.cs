using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //array - diziler (pythondaki listeler)
            // Köşeli parantez birden fazla string tutar


            string[] kurslar = new string[] { "Yazılım Geliştirici","Programlamaya başlama","Java" };



           

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            // i sayaç 
            // 1 den başla 10 dan küçük olduğu sürece devam ettir
            //++ 1er arttır demek
            //<= olsaydı 10 u da dahil edicekti
            //i=i+2 2 şer arttır demek
            //ya da i+=2


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sayfa Sonu");


            // Dizi temelli yapıları tek tek döner
            // Kursları tek tek dolaş demek
            // ilk for kalıbıyla aynı işlem

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
