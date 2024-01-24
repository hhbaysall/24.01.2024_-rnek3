using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._01._2024_örnek3
{
     public   class Ogranci
    {
       

        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }

        public double Ortalama
        {
            get { return (N1 + N2 + N3) / 3.0; }
        }
    }
}
