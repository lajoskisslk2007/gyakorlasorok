using System;
using System.Collections.Generic;
using System.Text;

namespace gyak
{
    public class menedzser:alkalmazott
    {
        public int Bonusz { get; set; }
        public menedzser(string nev, int alapber,int bonusz) : base(nev,alapber)
        {
            Bonusz = bonusz;
        }
    }
}
