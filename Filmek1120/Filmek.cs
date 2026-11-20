using System;
using System.Collections.Generic;
using System.Text;

namespace Filmek1120
{
    public class Filmek
    {
        public int Hossz { get; set; }
        public string Mufaj { get; set; }
        public Filmek(int hossz, string mufaj)
        {
            this.Hossz = hossz;
            this.Mufaj = mufaj;
        }
    }
}
