//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla

int[,] bingo = new int[3, 9];

var columnas1 = 3;
var columnas2 = 6;
int[] filas = new int[3];
filas[0] = 0;
filas[1] = 0;
filas[2] = 0;

for (int i = 0; i < 9; i++)
{
    var min = 0;
    var max = 0;

    int maxValue = filas.Max();
    int maxIndex = filas.ToList().IndexOf(maxValue);

    switch (i)
    {
        case 0:
            min = 1;
            max = 9;
            break;
        case 1:
            min = 10;
            max = 19;
            break;
        case 2:
            min = 20;
            max = 29;
            break;
        case 3:
            min = 30;
            max = 39;
            break;
        case 5:
            min = 40;
            max = 49;
            break;
        case 6:
            min = 50;
            max = 59;
            break;
        case 7:
            min = 60;
            max = 69;
            break;
        case 8:
            min = 70;
            max = 79;
            break;
        case 9:
            min = 80;
            max = 90;
            break;
        default:
            min = i * 10;
            max = i * 20;
            break;
    }

    var columna = new Random().Next(1, 3);
    if (columna == 1 && columnas1 > 0)
    {

        columnas1--;

        var fila = new Random().Next(0, 3);

        while (filas[fila] == 5 || fila == maxIndex)
        {
            fila = new Random().Next(0, 3);
        }
        filas[fila]++;

        var valor = new Random().Next(min, max);

        bingo[fila, i] = valor;
    }
    else
    {
        if (i == 8)
        {
            Console.WriteLine();
        }
        columnas2--;

        var fila = new Random().Next(0, 3);
        while (filas[fila] == 5 || fila == maxIndex)
        {
            fila = new Random().Next(0, 3);
        }
        filas[fila]++;


        var valor = new Random().Next(min, max);

        bingo[fila, i] = valor;

        var fila2 = new Random().Next(0, 3);
        while (filas[fila2] == 5 || fila2 == maxIndex)
        {
            fila2 = new Random().Next(0, 3);
        }
        filas[fila2]++;


        var valor2 = new Random().Next(min, max);

        bingo[fila2, i] = valor2;

    }
}

for (int i = 0; i < 3; i++)
{
    for (int x = 0; x < 9; x++)
    {
        if (bingo[i, x] != 0) { Console.Write(bingo[i, x]+"\t"); }
        //else { Console.WriteLine(" "); }

    }
    Console.WriteLine();
}