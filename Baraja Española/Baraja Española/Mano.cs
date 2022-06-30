using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española
{
    public class Mano
    {
        public const int CantidadCarta = 10;
        private Carta[] cartas = new Carta[CantidadCarta];
        private int count = 0;

        public void AgregarCarta(Carta darCarta)
        {
            if (this.count < CantidadCarta)
            {
                this.cartas[this.count] = darCarta;
                this.count++;
            }
        }
        public override string ToString()
        {
            string resultado = "";
            foreach(Carta carta in this.cartas)
            {
                resultado += carta.ToString() + "\n";
            }
            return resultado;
        }
    }
}
