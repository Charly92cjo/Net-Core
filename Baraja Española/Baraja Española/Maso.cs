using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española
{
    internal class Maso
    {
        public const int NumeroPalos = 4;
        public const int CartasPorPalos = 10;
        private Carta[,] masoCarta;
        private Random elegirCartaAzar = new Random();

        public Maso()
        {
            this.masoCarta = new Carta[NumeroPalos, CartasPorPalos];
            for (int i = 0; i < NumeroPalos; i++)
            {
                for (int j = 0; j < CartasPorPalos; j++)
                {
                    this.masoCarta[i, j] = new Carta((Palo)i, (Valor)j);
                }
            }
          
        }
        public Carta ReapartirCarta()
        {//Carta al azar
            Palo palo = (Palo)elegirCartaAzar.Next(0, NumeroPalos);
            while (this.NoHayMasCartas(palo))
            {
                palo = (Palo)elegirCartaAzar.Next(0, NumeroPalos);
            }
            //    int palo = elegirCartaAzar.Next(0, NumeroPalos);
            //    int valor = elegirCartaAzar.Next(0, CartasPorPalos);
            //    Carta carta = masoCarta[palo, valor];
            //    masoCarta[palo, valor] = null;
            //    return carta;
            Valor valor = (Valor)elegirCartaAzar.Next(CartasPorPalos);
            while (this.CartaRepetida(palo, valor)){
                valor = (Valor)elegirCartaAzar.Next(CartasPorPalos);
            }
            Carta carta = this.masoCarta[(int)palo, (int)valor];
            this.masoCarta[(int)palo, (int)valor] = null;
            return carta;
        }
            private bool NoHayMasCartas(Palo palo)
        {
            //for (int i = 0; i < CartasPorPalos; i++)
            //{
            //    if (masoCarta[(int)palo, i] != null)
            //    {
            //        return false;
            //    }
            //}
            //return true;
            bool resultado = true;
            for (int i = 0; i < CartasPorPalos; i++)
            {
                if (!CartaRepetida(palo, (Valor)i))
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }
        private bool CartaRepetida(Palo palo, Valor valor)
        {
            //for (int i = 0; i < CartasPorPalos; i++)
            //{
            //    if (masoCarta[(int)palo, i] == null || masoCarta[(int)palo, i].ValorBaraja() != valor)
            //    {
            //        continue;
            //    }
            //    return true;
            //}

            return (this.masoCarta[(int)palo, (int)valor] == null);

        }
    }
}
