using System;

namespace SayıTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tutulan = 0;
            int hak = 0;
            int kullanilanHak = 0;

            int ustAralik = 0;
            int altAralik = 1;


            Console.WriteLine("kolay seviye (1-12)-3 hak icin '3'");
            Console.WriteLine("orta seviye (1-24)- 6 hak icin'6'");
            Console.WriteLine("zor seviye (1-48)-8 hak icin '8'");
            Console.Write("zorluk seviyesini seçiniz = ");
            int seviye = Convert.ToInt32(Console.ReadLine());

            switch (seviye)
            {
                case 3:
                    ustAralik = 12;
                    tutulan = rand.Next(1, 12);
                    hak = 3;
                    break;

                case 4:
                    ustAralik = 24;
                    tutulan = rand.Next(1, 24);
                    hak = 6;
                    break;

                case 5:
                    ustAralik = 48;
                    tutulan = rand.Next(1, 48);
                    hak = 8;
                    break;
                default:
                    Console.Write("Geçerli olmayan zorluk seçtiniz");
                    break;

            }

            int sayi = 0;
            while (kullanilanHak < hak)
            {
                Console.Write("{0} - {1} arasında bir sayı giriniz : ", altAralik, ustAralik);
                sayi = int.Parse(Console.ReadLine());
                kullanilanHak++;

                if (sayi == tutulan)
                {
                    //kullanıcının tahmini doğrudur.
                    Console.WriteLine("Tebrikler.{0} hakkınızda bildiniz.", kullanilanHak);
                    break;
                }
                else
                {
                    if (sayi > ustAralik)
                    {
                        Console.WriteLine("Aralıktan büyük bir sayı girdiniz.");
                        break;
                    }
                    else if (sayi < altAralik)
                    {
                        Console.WriteLine("Aralıktan küçük bir sayı girdiniz.");
                        break;
                    }

                    if (sayi > tutulan)
                    {
                        Console.WriteLine("Daha küçük bir değer giriniz.");
                    }
                    else
                    {
                        Console.WriteLine("Daha büyük bir değer giriniz.");
                    }

                }
                Console.WriteLine("{0} hakkınız kaldı .", hak - 1);
                {
                    if (hak - kullanilanHak == 0)
                    {
                        Console.WriteLine(" Üzgünüz hakkınız bitti.");
                        Console.WriteLine("tutan sayı :{0}", tutulan);
                        break;
                    }
                }
            }
        }
    }
}

