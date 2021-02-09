using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManeger = new GamerManager();
            OyunSatisManager oyunSatis = new OyunSatisManager();
            IKampanyaManager kampanyaManager = new KampanyaManager();
            string authenTc;

            
            Console.WriteLine("T.C nizi girmelisiniz..");
            authenTc = Console.ReadLine();
            
            while(true)
            {
                Console.WriteLine("----------Oyuncu Reposuna HOŞGELDİNİZ----------");
                Console.WriteLine("1-Oyuncu Ekle");
                Console.WriteLine("2-Oyuncu Güncelle");
                Console.WriteLine("3-Oyuncu Sil");
                Console.WriteLine("4-Oyuncu Bul");
                Console.WriteLine("5-Oyun Satın Al");
                Console.WriteLine("6-Kampanya Ekle");
                Console.WriteLine("7-Kampanya Sil");
                Console.WriteLine("8-Kampanya Güncelle");
                Console.WriteLine("9-Çıkış");
                Console.Write("Secim Yapınız : ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        if (!(gamerManeger.Find(authenTc)))
                        {
                            gamerManeger.Add(authenTc);
                        }
                        break;
                    case "2":
                        gamerManeger.Update(authenTc);
                        break;
                    case "3":
                        gamerManeger.Delete(authenTc);
                        break;
                    case "4":
                        gamerManeger.Find(authenTc);
                        break;
                    case "5":
                        List<IOyunlar> sepet = oyunSatis.Sepet();
                        double fiyat = oyunSatis.Hesapla(sepet);
                        if (fiyat != 0 )
                        {
                            kampanyaManager.IndirimUygula(fiyat);
                            oyunSatis.Satis(gamerManeger.Sent(authenTc), sepet);
                        }
                        break;
                    case "6":
                        kampanyaManager.Add();
                        break;
                    case "7":
                        kampanyaManager.Delete();
                        break;
                    case "8":
                        kampanyaManager.Update();
                        break;
                    case "9":
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }
            }            
        }
    }
}
