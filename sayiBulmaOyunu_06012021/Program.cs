using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulmaOyunu_06012021
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgeleSayiÜretici = new Random();
            int uretilenSayi = rastgeleSayiÜretici.Next(1, 100);

            while (true)
            {
                Console.WriteLine("Tahmininizi giriniz:");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı!");
                }
                else
                {
                    Console.WriteLine("Tebrikler doğru sayıyı buldunuz :) ");

                    char verilenCevap;
                    
                    while (true) //Kullanıcının istenilen şekilde girdi girip girmediği kontrol edildi.
                    {
                        Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)");
                        verilenCevap = Convert.ToChar(Console.ReadLine().Trim()); //Trim ile olası boşluk bırakma durumu engellendi.
                        if (new[] { 'E','e','H','h' }.Contains(verilenCevap)) //Girdide listedeki elemanların varlığı kontrol edildi.
                            break;
                        else
                        {
                            Console.WriteLine("Hatalı giriş lütfen tekrar deneyiniz!");
                        }
                    }
                    //Kullanıcı istenilen şekilde girdi girmişse while döngüsünden çıkılıp verilen cevap kontrol edildi.
                    if (verilenCevap == 'H' || verilenCevap == 'h')
                        break;
                    else if (verilenCevap == 'E' || verilenCevap == 'e')
                        Console.WriteLine("Oyun yeniden başlatılıyor. İyi eğlenceler :) ");
                }
            }
        }

    }
}
