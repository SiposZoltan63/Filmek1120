using System;
using System.Collections.Generic;
using System.Text;

namespace Filmek1120
{
    public class Filmek
    {
        public String Cim { get; set; }
        public int Hossz { get; set; }
        public string Mufaj { get; set; }
        public Filmek(string cim,int hossz, string mufaj)
        {
            this.Cim = cim;
            this.Hossz = hossz;
            this.Mufaj = mufaj;
        }
    }
}
