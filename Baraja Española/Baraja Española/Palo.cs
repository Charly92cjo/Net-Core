using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española
{
    public class Palo
     //palo = espada copa oro basto    
    {
        readonly string[] palo = new string[10];
        public Palo()
        {
            palo[0] = "espada";
            palo[1] = "copa";
            palo[2] = "oro";
            palo[3] = "basto";
        }

        public static explicit operator int(Palo v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Palo(int v)
        {
            throw new NotImplementedException();
        }
    }
}
