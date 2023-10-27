using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 1;
        }

        public double GetFajsuly { get => fajsuly; }

        public double Suly { get => fajsuly * Terfogat(); }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat():N2}; sugár:{GetSugar:N2}; magasság:{GetMagassag:N2}; fajsúly:{fajsuly:N2}";
        }
    }
}