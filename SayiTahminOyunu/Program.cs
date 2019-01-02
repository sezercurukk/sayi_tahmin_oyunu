using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {


            string cevap = "";

            do
            {
                Console.Title = "Sayı Tahmin Oyunu";
                Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz.");
                Console.WriteLine("**********************************");

                int tahmin = 0;
                int hafiza = 0;
                int sayac = 0;
                



                Random rastgale = new Random();
                hafiza = rastgale.Next(1, 10);

                while (tahmin != hafiza)
                {
                    sayac++;
                    Console.Write("Sayı Giriniz :");
                    tahmin = int.Parse(Console.ReadLine());

                    if (tahmin > hafiza)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz");
                    }
                    else if (tahmin < hafiza)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz");
                    }



                }

                Console.WriteLine("Tebriklerrrr sayıyı buldunuz.");
                Console.WriteLine("{0}. denemede sayıyı buldunuz.", sayac);
                Console.WriteLine("Oyunu tekrar oynamak ister misiniz ? [E]vet , [H]ayır ??");
                cevap = Console.ReadLine();

                Console.Clear();
                

            } while (cevap =="E"|| cevap == "e" );

            Console.WriteLine("Sayı bulma oyununu oynadığınız için teşekkürler");
            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadLine();




        }
    }
}
