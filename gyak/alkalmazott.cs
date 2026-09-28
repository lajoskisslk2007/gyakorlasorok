using System;
using System.Collections.Generic;
using System.Text;

namespace gyak
{
    public class alkalmazott
    {
        public string Nev { get; set; }
        protected int Alapber { get; set; }
        public alkalmazott(string nev ,int alapber)
        {
            Nev = nev;
            Alapber = alapber;
        }
        public virtual int fizetesszamitas()
        {
            return Alapber;
        }
        public override string ToString()
        {
            return $"Név:{Nev}, fizetés:{fizetesszamitas()}ft";
        }

    }
}
