using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IGamerManager
    {
        public void Add(string Tc);
        public bool Delete(string Tc);
        public bool Update(string Tc);
        public bool Find(string Tc);
        public void Yazdir(Gamer gamer);
        public Gamer Sent(string Tc);
    }
}
