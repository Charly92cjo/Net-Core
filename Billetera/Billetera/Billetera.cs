using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBilletera
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total(Billetera item)
        {
            decimal total = BilletesDe10 * 10 + 
                            BilletesDe20 * 20 + 
                            BilletesDe50 * 50 + 
                            BilletesDe100 * 100 + 
                            BilletesDe200 * 200 +
                            BilletesDe500 * 500 + 
                            BilletesDe1000 * 1000;
            return total;
        }

        public string Detalle(Billetera item) 
        {
            return  BilletesDe10 +" billetes de 10\n" + 
                    BilletesDe20 + " billetes de 20\n" + 
                    BilletesDe50 + " billetes de 50\n" + 
                    BilletesDe100 + " billetes de 100\n" + 
                    BilletesDe200 + " billetes de 200\n" + 
                    BilletesDe500 + " billetes de 500\n" + 
                    BilletesDe1000 + " billetes de 1000\n";
        }
        public Billetera Combinar(Billetera segundaBilletera)
        {
            Billetera nuevaBilletera = new Billetera();
            int SumaDe10 = BilletesDe10 + segundaBilletera.BilletesDe10;
            int SumaDe20 = BilletesDe20 + segundaBilletera.BilletesDe20;
            int SumaDe50 = BilletesDe50 + segundaBilletera.BilletesDe50;
            int SumaDe100 = BilletesDe100 + segundaBilletera.BilletesDe100;
            int SumaDe200 = BilletesDe200 + segundaBilletera.BilletesDe200;
            int SumaDe500 = BilletesDe500 + segundaBilletera.BilletesDe500;
            int SumaDe1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000;
            return nuevaBilletera;
        }
        //public static Billetera Borrar(Billetera item)
        //{
            
           
        //}
    }
}

