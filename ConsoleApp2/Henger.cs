using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Henger
    {
        private double sugar;
        private double magassag;
        private static int szuletesSzamlalo=0;

        public double GetMagassag { get => magassag; }

        public double GetSugar { get => sugar; }

        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Pow(sugar, 2)*Math.PI*magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Terfogat():N2}; sugár:{sugar:N2}; magasság:{magassag:N2}";
        }

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo++;
        }
    }
}

