using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor.
            int[] sayilar = new int[10];

            // 2 - Dizinin elemanlarını for döngüsü ile dolduruyoruz.
            Console.WriteLine("Dizi elemanlarını giriniz:");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"Eleman {i + 1}: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Foreach döngüsü ile diziyi ekrana yazdırıyoruz.
            Console.WriteLine("\nGirilen dizi elemanları:");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();

            // 3 - Kullanıcıdan alınan yeni bir değeri diziye ekliyoruz (11. eleman)
            Console.Write("\nEklemek istediğiniz yeni sayıyı giriniz: ");
            int yeniSayi = Convert.ToInt32(Console.ReadLine());

            // Yeni dizi oluşturularak elemanlar ve yeni sayı ekleniyor
            int[] yeniDizi = new int[sayilar.Length + 1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                yeniDizi[i] = sayilar[i];
            }
            yeniDizi[yeniDizi.Length - 1] = yeniSayi;

            // 4 - Diziyi büyükten küçüğe sıralayıp ekrana yazdırıyoruz.
            Array.Sort(yeniDizi);
            Array.Reverse(yeniDizi);

            Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
            foreach (int sayi in yeniDizi)
            {
                Console.Write(sayi + " ");
            }

            Console.WriteLine("\n\nProgram sona erdi.");
        }
    }
}
