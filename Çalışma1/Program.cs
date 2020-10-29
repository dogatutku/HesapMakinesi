
using System;

namespace Çalışma1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaşlıkYaz();
            Console.WriteLine("Birinci Sayı:");
            double birincisayı = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci Sayı:");
            double ikincisayı = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hangi İşlemi Yapmak İstiyorsunuz?");
            string islem = Console.ReadLine();

            islemYaptır(birincisayı, ikincisayı, islem);

            Console.ReadLine();
        }

        static void islemYaptır(double birinciSayı, double ikinciSayı, string islem)
        {


            if (islem == "+")
            {
                double sonuc = (birinciSayı + ikinciSayı);

                Console.WriteLine("Toplam:" + sonuc);
            }

            else if (islem == "-")
            {
                double sonuc = (birinciSayı - ikinciSayı);
                Console.WriteLine("Çıkarma:" + sonuc);
            }

            else if (islem == "*")
            {
                double sonuc = (birinciSayı * ikinciSayı);
                Console.WriteLine("Çarpma" + sonuc);

            }

            else if (islem == "/")
            {
                double sonuc = (birinciSayı / ikinciSayı);
                Console.WriteLine("Bölme" + sonuc);
            }
            else
            {
                Console.WriteLine("Lütfen Dört İşlemden Birini Giriniz!!");
            }


        }

        static void BaşlıkYaz()
        {
            Console.WriteLine("**HESAP MAKİNESİ**");

        }


    }






}







