using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerManager
    {
        List<Gamer> gamerList = new List<Gamer>();
        public void Add(string Tc)
        {
            Console.Clear();
            Gamer gamer1 = new Gamer();
            
            Console.Write("Ad :");
            gamer1.FirstName = Console.ReadLine();

            Console.Write("Soyad :");
            gamer1.LastName = Console.ReadLine();

            gamer1.Tc = Tc;

            Console.Write("Doğum Yılı :");
            gamer1.BirthYear = Console.ReadLine();

            gamer1.Id = gamerList.Count + 1;

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            if (gamerCheckManager.GamerCheck(gamer1))
            {
                gamerList.Add(gamer1);
                Console.WriteLine("Eklendi " + gamer1.FirstName);
            }
            else
            {
                Console.WriteLine("Maalesef kullanıcı doğrulanamadı");
            }
            
            
        }

        public bool Delete(string Tc)
        {
            for (int i = 0; i < gamerList.Count; i++)
            {
                if (Tc == gamerList[i].Tc)
                {
                    gamerList.Remove(gamerList[i]);
                    Console.WriteLine("Oyuncu silindi.");
                    return true;
                }
            }
            Console.WriteLine("Oyuncu bulunamadı.");
            return false;
        }

        public bool Update(string Tc)
        {
            Console.Clear();
            for (int i = 0; i < gamerList.Count; i++)
            {
                if (Tc == gamerList[i].Tc)
                {
                    Console.Write("Ad :");
                    gamerList[i].FirstName = Console.ReadLine();

                    Console.Write("Soyad :");
                    gamerList[i].LastName = Console.ReadLine();

                    gamerList[i].Tc = Tc;

                    Console.Write("Doğum Yılı :");
                    gamerList[i].BirthYear = Console.ReadLine();
                    return true;
                }
            }
            Console.WriteLine("Oyuncu bulunamadı.");
            return false;
        }

        public bool Find(string Tc)
        {
            Console.Clear();
            for (int i = 0; i < gamerList.Count; i++)
            {
                if (Tc == gamerList[i].Tc)
                {
                    Console.WriteLine("Oyuncu bulundu.");
                    Console.WriteLine("---------------------");
                    Yazdir(gamerList[i]);
                    return true;
                }
            }
            Console.WriteLine("Oyuncu bulunamadı.");
            return false;
        }

        public void Yazdir(Gamer gamer)
        {
            Console.WriteLine("İsim :" + gamer.FirstName);
            Console.WriteLine("Soyisim :" + gamer.LastName);
            Console.WriteLine("T.C :" + gamer.Tc);
            Console.WriteLine("Doğum Yılı :" + gamer.BirthYear);
        }

        public Gamer Sent(string Tc)
        {
            for (int i = 0; i < gamerList.Count; i++)
            {
                if (Tc == gamerList[i].Tc)
                {                  
                    return gamerList[i];
                }
            }
            Console.WriteLine("Oyuncu bulunamadı.");
            throw new Exception("Hata!"); 
        }
    }
}
