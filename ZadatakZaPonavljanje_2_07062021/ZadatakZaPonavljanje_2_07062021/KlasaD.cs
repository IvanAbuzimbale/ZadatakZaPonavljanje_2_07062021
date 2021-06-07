using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje_2_07062021
{
    class KlasaD
    {
        static public bool Suprotno (bool suprotno)
        {
            return !suprotno;
        }

        static public int Suprotni (int suprotni)
        {
            int suprotna = 0;
            int broj = -1;
            suprotna = broj * suprotni;
            return suprotna;
        } 
    }
}
