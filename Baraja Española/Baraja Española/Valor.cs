using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española
{
    public class Valor
    {//valor del 1 al 12
        readonly string[] valor = new string[10];
        public Valor()
        {
            valor[0] = "Uno";
            valor[1] = "Dos";
            valor[2] = "Tres";
            valor[3] = "Cuatro";
            valor[4] = "Cinco";
            valor[5] = "Seis";
            valor[6] = "Siete";
            valor[7] = "Diez";
            valor[8] = "Once";
            valor[9] = "Doce";
            //valor[0] = "1";
            //valor[1] = "2";
            //valor[2] = "3";
            //valor[3] = "4";
            //valor[4] = "5";
            //valor[5] = "6";
            //valor[6] = "7";
            //valor[7] = "11";
            //valor[8] = "10";
            //valor[9] = "12";
        }

        public static explicit operator Valor(int v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator int(Valor v)
        {
            throw new NotImplementedException();
        }
    }
}
