using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IOyunsatis
    {
        public List<IOyunlar> Sepet();
        public double Hesapla(List<IOyunlar> oyunlars);
        public void Satis(Gamer gamer,List<IOyunlar> oyunlars);
    }
}
