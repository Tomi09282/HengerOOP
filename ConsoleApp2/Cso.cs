using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag, double falVastagsag, double a) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falVastagsag=1;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            return Math.Pow(GetSugar, 2) * Math.PI * GetMagassag - Math.Pow((GetSugar - falVastagsag), 2) * Math.PI * GetMagassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat():N2}; sugár:{GetSugar:N2}; magasság:{GetMagassag:N2}; falvastagság:{falVastagsag:N2}";
        }
    }
}