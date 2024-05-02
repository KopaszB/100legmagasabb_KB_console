using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100legmagasabb_KB
{
    class Epulet
    {

        public int Rang { get; set; }
        public string Nev { get; set; }
        public string Varos_orszag { get; set; }
        public double Magassag_m { get; set; }
        public int Magassag_ft { get; set; }
        public int Emeletek_szama { get; set; }
        public int Epites_eve { get; set; }


        public Epulet(int rang, string nev, string varos_orszag, double magassag_m, int magassag_ft, int emeletek_szama, int epites_eve)
        {
            Rang = rang;
            Nev = nev;
            Varos_orszag = varos_orszag;
            Magassag_m = magassag_m;
            Magassag_ft = magassag_ft;
            Emeletek_szama = emeletek_szama;
            Epites_eve = epites_eve;
        
        }
        public bool Tutiepulet() 
        {
            bool ertek = false;
            if (this.Magassag_m > 500 && this.Emeletek_szama > 100)
            {
                ertek = true;
            }
            else
            {
                ertek = false;
            }
            
            return ertek;
        }
    }

}
