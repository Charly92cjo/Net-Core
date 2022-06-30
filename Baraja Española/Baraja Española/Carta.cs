using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja_Española
{
    public class Carta
    {
        private readonly Palo palo;
        private readonly Valor valor;


        public Carta(Palo p, Valor v)
        {
            this.palo = p;
            this.valor = v;
        }
       
        public override string ToString()
        {
            string resultado = string.Format($"{0} de {1}", this.valor, this.palo);
            return resultado;
        }
        public Palo PaloBaraja()
        {
            return this.palo;
        }
        public Valor ValorBaraja()
        {
            return this.valor;
        }
        
    }
   
}
