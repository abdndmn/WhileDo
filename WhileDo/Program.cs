// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

namespace WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanicinin girdigi bir limit degerine kadar 0'dan bir sayac calistirip artirarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

            //1. While ile yapılan uygulama:
            int sayac1 = 0;
            Console.WriteLine("Lütfen limit değerini giriniz:");
            int limit1 = Convert.ToInt32(Console.ReadLine());

            while (sayac1 <= limit1)
            {

                sayac1++;
                Console.WriteLine("Ben bir Patika'liyim.");

            }

            //2. Do-While ile yapılan uygulama:

            int sayac2 = 0;
            Console.WriteLine("Lütfen limit değerini giriniz:");
            int limit2 = Convert.ToInt32(Console.ReadLine());
            do
            {
                sayac2++;
                Console.WriteLine("Ben bir Patika'liyim.");
            } while (sayac2 <= limit2);
            //While loop ile koşul scope öncesi giirldiği için eğer koşul sağlanmıyorsa scope içindeki işlemler çalışmaz.
            //Do-While ile koşul döngü sonrası girildiği için döngü 1 kez döner ve koşul daha sonra kontrol edilir.
            //Bundan dolayı, Do- While'da Konsolda girilen Limit değerinden +1 daha fazla output gelir.







        }

    }
}
