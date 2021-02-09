using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class KampanyaManager : IKampanyaManager
    {
        public List<IKampanya> kampanyas = new List<IKampanya>();

        public void Add()
        {
            Console.Clear();
            IKampanya kampanya = new Kampanya();
            Console.WriteLine("Kampanya ismi");
            kampanya.KampanyaIsmi = Console.ReadLine();

            Console.WriteLine("Kampanya oranı");
            kampanya.IndirimOranı = Convert.ToInt32(Console.ReadLine());
            kampanyas.Add(kampanya);
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete()
        {
            string secim;
            Yazdir();
            Console.WriteLine("Silmek istediğiniz kampanyanın ismini yazınız.");
            secim = Console.ReadLine();
            for(int i = 0; i<kampanyas.Count; i++)
            {
                if (kampanyas[i].KampanyaIsmi == secim)
                {
                    kampanyas.Remove(kampanyas[i]);
                    Console.WriteLine("Silindi");
                }
            }
        }

        public double IndirimUygula(double fiyat)
        {
            int secim;
            Yazdir();
            Console.WriteLine("Kampanya seçiniz");
            secim = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< kampanyas.Count; i++)
            {
                if(secim == i)
                {
                    double kampanyaliFiyat = fiyat - ((fiyat * kampanyas[i].IndirimOranı) / 100);
                    Console.WriteLine("Fiyat :" + kampanyaliFiyat);
                    return kampanyaliFiyat;
                }
            }
            return fiyat;
        }

        public void Update()
        {
            Console.Clear();
            string secim;
            Yazdir();
            Console.WriteLine("Güncelleme istediğiniz kampanyanın ismini yazınız.");
            secim = Console.ReadLine();
            for (int i = 0; i < kampanyas.Count; i++)
            {
                if (kampanyas[i].KampanyaIsmi == secim)
                {
                    Console.WriteLine("Yeni indirim oranı");
                    kampanyas[i].IndirimOranı = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncellendi");
                }
            }
        }

        public void Yazdir()
        {
            for(int i=0; i < kampanyas.Count; i++)
            {
                Console.WriteLine(i + ". Kampanya İsmi:" + kampanyas[i].KampanyaIsmi + " ~ İndirim Oranı: " + kampanyas[i].IndirimOranı);
            }
        }
    }
}
