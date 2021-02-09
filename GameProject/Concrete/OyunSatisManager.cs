using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class OyunSatisManager : IOyunsatis
    {
        public KampanyaManager kampanyamanager;

        IOyunlar oyunlar1 = new Satisfactory { Fiyat = 50, OyunIsmi = "Satisfactory" };
        IOyunlar oyunlar2 = new Cyberpunk { Fiyat = 300, OyunIsmi = "Cyberpunk" };
        IOyunlar oyunlar3 = new CsGo { Fiyat = 70, OyunIsmi = "CsGo" };

        public double Hesapla(List<IOyunlar> oyunlars)
        {
            double fiyat = 0;
            foreach(IOyunlar oyun in oyunlars)
            {
                fiyat += oyun.Fiyat;
            }
            return fiyat;

        }

        public void Satis(Gamer gamer, List<IOyunlar> oyunlars)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Oyuncu İsmi: " + gamer.FirstName);
            foreach(IOyunlar oyun in oyunlars)
            {
                Console.WriteLine("Satın Alınan Oyun: " + oyun.OyunIsmi);
            }
        }

        public List<IOyunlar> Sepet()
        {
            Console.Clear();

            List<IOyunlar> sepet = new List<IOyunlar>();

            Console.WriteLine("1- " + oyunlar1.OyunIsmi);
            Console.WriteLine("2- " + oyunlar2.OyunIsmi);
            Console.WriteLine("3- " + oyunlar3.OyunIsmi);
            Console.WriteLine("4- Onayla");
            Console.WriteLine("Almak istediğiniz oyunun numarasını giriniz.");

            string secim;
            bool deger = true;
            while (deger)
            {
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        sepet.Add(oyunlar1);
                        Console.WriteLine("Eklendi");
                        break;
                    case "2":
                        sepet.Add(oyunlar2);
                        Console.WriteLine("Eklendi");
                        break;
                    case "3":
                        sepet.Add(oyunlar3);
                        Console.WriteLine("Eklendi");
                        break;
                    case "4":
                        deger = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim");
                        break;
                }           
            }
            return sepet;

        }
    }
}
