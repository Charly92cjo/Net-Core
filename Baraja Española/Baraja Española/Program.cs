//1 - Barajar
//2 - Mostrar siguiente carta
//3 - Mostrar cartas disponibles
//4 - Dar cartas
//5 - Mostrar cartas del monton
//6 - Mostrar baraja
//7 - Salir

using Valor = Baraja_Española.Valor;
using Palo = Baraja_Española.Palo;
using Carta = Baraja_Española.Carta;

//barajar 

Console.WriteLine("Bienvenidos al juguego de cartas");
Console.WriteLine("Para barajar pulse 1");
Console.WriteLine("Para mostrar la siguiente carta pulse 2");
Console.WriteLine("Para mostrar las cartas disponibles pulse 3");
Console.WriteLine("Para dar cartas pulse 4");
Console.WriteLine("Para mostrar las cartas del monton pulse 5");
Console.WriteLine("Para mostrar la baraja pulse 6");
Console.WriteLine("Para salir pulse 7");
int opcion;
do
{
    Console.WriteLine("Pulse una opcion");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Barajando...");
            ReapartirCarta();
            break;
        case 2:
            Console.WriteLine("Mostrando la siguiente carta...");
            ReapartirCarta();
            break;
        case 3:
            Console.WriteLine("Mostrando las cartas disponibles...");
            break;
        case 4:
            Console.WriteLine("Dar cartas...");
            break;
        case 5:
            Console.WriteLine("Mostrando las cartas del monton...");
            break;
        case 6:
            Console.WriteLine("Mostrando la baraja...");
            break;
        case 7:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
} while (opcion != 7);

void ReapartirCarta()
{
    throw new NotImplementedException();
}