/*Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de 
billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion 
del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/
using MiBilletera;

Billetera[] billeteras = new Billetera[2];
billeteras[0] = new Billetera();
billeteras[1] = new Billetera();

foreach(var item in billeteras)
{
    Console.WriteLine("Ingrese la cantidad de Billetes de $10 de la 1° Billetera");
    int de10 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $20 de la 1° Billetera");
    int de20 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $50 de la 1° Billetera");
    int de50 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $100 de la 1° Billetera");
    int de100 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $200 de la 1° Billetera");
    int de200 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $500 de la 1° Billetera");
    int de500 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de Billetes de $1000 de la 1° Billetera");
    int de1000 = Int32.Parse(Console.ReadLine());

    item.BilletesDe10 = de10;
    item.BilletesDe20 = de20;
    item.BilletesDe50 = de50;
    item.BilletesDe100 = de100;
    item.BilletesDe200 = de200;
    item.BilletesDe500 = de500;
    item.BilletesDe1000 = de1000;
}

Console.WriteLine("Tienes un total de $" + billeteras[0].Total(billeteras[0]) + " en la 1° Billetera\n");
Console.WriteLine("Tienes un total de $" + billeteras[1].Total(billeteras[1]) + " en la 2° Billetera\n");
Console.WriteLine("Tienes "+billeteras[0].Detalle(billeteras[0])+"\n");
Console.WriteLine("Tienes "+billeteras[1].Detalle(billeteras[1])+"\n");
Billetera b3 = billeteras[0].Combinar(billeteras[1]);
Console.WriteLine("$" + b3.Total(b3) + " en la 3° Billetera\n");

