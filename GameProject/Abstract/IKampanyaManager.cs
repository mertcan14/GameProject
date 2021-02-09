using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IKampanyaManager
    {
        public void Add();
        public void Update();
        public void Delete();
        public void Yazdir();
        public double IndirimUygula(double fiyat);

    }
}
