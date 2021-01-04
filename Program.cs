using System;

namespace Sayitahminioyunuu
{
    class Program
    {
        static void Main(string[] args)
        {
            etap1();
            void etap1()
            {
                Console.WriteLine("Sayı Tahmin oyununa Hoş Geldiniz İyi Eğlenceler");


                int belirlenen, tahmin, hak = 6;
                Random rnd = new Random();
                belirlenen = rnd.Next(1, 11);
                Console.WriteLine("Oyunun 1. Etabına Hoşgeldiniz bu etapta 6 adet hakkınız bulunmaktadır");

                for (; ; )
                {
                    if (hak == 0)
                    {
                        Console.WriteLine("Hakkınız bitti! Kaybettiniz");
                        etap1();


                    }

                    Console.WriteLine("1 ile 10 Arasında Bir Sayı Giriniz");
                    tahmin = int.Parse(Console.ReadLine());
                    if (belirlenen == tahmin)
                    {
                        Console.WriteLine("Tebrikler Sayıyı Doğru Tahmin Ettiniz");

                        etap2();


                    }
                    else if (belirlenen < tahmin)
                    {
                        Console.WriteLine("Daha Alçak Bir Sayı Giriniz");
                    }
                    else
                    {
                        Console.WriteLine("Daha Yüksek Bir Sayı Giriniz");
                    }
                    hak--;
                    Console.WriteLine("Kalan tahmin hakkınız; " + hak);

                }
            }


            void etap2()
            {

                Console.WriteLine("2.Etaba Hoşgeldiniz Bu Etapta 4 adet Hakkınız Var");


                int belirlenen2, tahmin2, hak2 = 4;
                Random rnd2 = new Random();
                belirlenen2 = rnd2.Next(1, 26);

                for (; ; )
                {
                    if (hak2 == 0)
                    {
                        Console.WriteLine("Kaybettiniz! Hakkınız Bitti");
                        etap2();


                    }

                    Console.WriteLine("1 ile 25 Arasında Bir Sayı Giriniz");
                    tahmin2 = int.Parse(Console.ReadLine());
                    if (belirlenen2 == tahmin2)
                    {
                        Console.WriteLine("Tebrikler Bildiniz");

                        etap3();

                    }
                    else if (belirlenen2 < tahmin2)
                    {
                        Console.WriteLine("Daha Alçak Bir Sayı Giriniz");
                    }
                    else
                    {
                        Console.WriteLine("Daha Yüksek Bir Sayı Giriniz");
                    }
                    hak2--;
                    Console.WriteLine("Kalan tahmin hakkınız; " + hak2);
                }
            }


            void etap3()
            {
                Console.WriteLine("3. Etaba Hoşgeldiniz bu etapta 2 adet hakkınız var");


                int belirlenen3, tahmin3, hak3 = 2;
                Random rnd3 = new Random();
                belirlenen3 = rnd3.Next(1, 51);

                for (; ; )
                {
                    if (hak3 == 0)
                    {
                        Console.WriteLine("Hakkınız bitti! Kaybettiniz");
                        break;
                    }

                    Console.WriteLine("1 ile 50 Arasında Bir Sayı Giriniz");
                    tahmin3 = int.Parse(Console.ReadLine());
                    if (belirlenen3 == tahmin3)
                    {
                        Console.WriteLine("Tebrikler Sayıyı Doğru Tahmin Ettiniz");
                        bitis();

                    }
                    else if (belirlenen3 < tahmin3)
                    {
                        Console.WriteLine("Daha Alçak Bir Sayı Giriniz");
                    }
                    else
                    {
                        Console.WriteLine("Daha Yüksek Bir Sayı Giriniz");
                    }
                    hak3--;
                    Console.WriteLine("Kalan tahmin hakkınız " + hak3);
                }





            }
            void bitis()
            {
                Console.WriteLine("Oyunumuz Bitmiştir");
                Console.WriteLine("Tekrar oynamak için '1' e basınız\n Programı sonlandırmak için '2' a basınız");
                int Tekrar;
                Tekrar = int.Parse(Console.ReadLine());
                if (Tekrar == 1)
                {
                    etap1();
                }
                else
                {

                    Environment.Exit(2);
                }
            }
        }
    }
}
