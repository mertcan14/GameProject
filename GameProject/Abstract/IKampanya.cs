using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IKampanya
    {
        public string KampanyaIsmi { get; set; }
        public int IndirimOranı { get; set; }
    }
}
