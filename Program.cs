using System;

namespace PROJEM2
{
    class Program
    {
        static void Main(string[] args)
        {


            int ktpısbn;
            int rafno;
            Console.WriteLine(" Kutuphane Kayıt Sistemine Hos Geldınız");
            string adı, soyadı, TC;

            Console.WriteLine("Adınızı gırınız:");
            adı = Console.ReadLine();

            Console.WriteLine("Soyadınızı gırınız:");
            soyadı = Console.ReadLine();

            Console.WriteLine("TC nızı gırınız:");
            TC = Console.ReadLine();

            Console.WriteLine("Almak istediğiniz kitabın  raf numarasını  giriniz:");
            rafno = Convert.ToInt32(Console.ReadLine());

                if (rafno == 1)
                {
                    Console.WriteLine("Almak ıstedıgınız kıtabın ısbn numarasını gırınız:");
                    ktpısbn = Convert.ToInt32(Console.ReadLine());
                    if (ktpısbn == 12345)
                    {

                        Console.WriteLine("1-Suç ve Ceza – Fyodor Dostoyevski Kitabını aldınız. ");
                    Console.WriteLine("2-Kardeşimin Hikayesi-Zülfü Livaneli Kitabını aldınız.");
                    Console.WriteLine("3-Şimşek - Peyami Safa");
                        Console.WriteLine("Kaydınız basarılı bır sekılde olusmustur.");

                    }
            }

            else if (rafno == 2)
            {
                Console.WriteLine("Almak ıstedıgınız kıtabın ısbn numarasını gırınız:");
                ktpısbn = Convert.ToInt32(Console.ReadLine());
                if (ktpısbn == 6789)
                {
                    Console.WriteLine("1- Sefiller – Victor Hugo kıtabını aldınız.");
                    Console.WriteLine("2-Kürk Mantolu Madonna -Sabahattin Ali");
                    Console.WriteLine("3-Babaya Mektup - Franz Kafka");
                    Console.WriteLine("Kaydınız basarılı bır sekılde olusmustur.");
                }

            }
            else if (rafno == 3)
            {
                Console.WriteLine("Almak ıstedıgınız kıtabın ısbn numarasını gırınız:");
                ktpısbn = Convert.ToInt32(Console.ReadLine());

                if (ktpısbn == 2468)
                {
                    Console.WriteLine(" 1- Anna Karenina – Lev Tolstoy");
                    Console.WriteLine("2-İçimizdeki Şeytan - Sabahhtin Ali");
                    Console.WriteLine("3-Dönüşüm- Franz Kafka");
                    Console.WriteLine("Kaydınız basarılı bır sekılde olusmustur.");
                }

            }
            else if (rafno == 4)
            {
                Console.WriteLine("Almak ıstedıgınız kıtabın ısbn numarasını gırınız:");
                ktpısbn = Convert.ToInt32(Console.ReadLine());

                if (ktpısbn == 1357)
                {

                    Console.WriteLine("  1- Vadideki Zambak – Honoré de Balzac");
                    Console.WriteLine("2-Piraye - Canan Tan");
                    Console.WriteLine("3- Bilinmeyen Bir Kadının Mektubu -Stefan Zweig");
                    
                    Console.WriteLine("Kaydınız basarılı bır sekılde olusmustur.");
                }
            }
            else if (rafno == 5)
            {
                Console.WriteLine("Almak ıstedıgınız kıtabın ısbn numarasını gırınız:");
                ktpısbn = Convert.ToInt32(Console.ReadLine());
                if (ktpısbn == 1248)
                {
                    Console.WriteLine(" 1-Aşk ve Gurur – Jane Austen");
                    Console.WriteLine("2-Gençliğimiz - Peyami Safa");
                    Console.WriteLine("3-Tututanamayanlar - Oguz Atay");
                    Console.WriteLine("Kaydınız basarılı bır sekılde olusmustur.");
                }
            }
            else
            {
                Console.WriteLine("Kaydınız yapılamamıstır tekrar deneyınız....");
            }
            Console.ReadLine();

        }
    
    }

}
