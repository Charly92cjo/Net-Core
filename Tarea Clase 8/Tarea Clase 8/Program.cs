
//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios

Console.WriteLine("Bien ahora vamos a crear una matriz de dos dimensiones de tipo int llamada numeros");
Console.WriteLine("Que valor querés que tenga la primera parte de la matriz?");
int Matriz = int.Parse(Console.ReadLine());
Console.WriteLine("Que valor querés que tenga la la segunda parte de la matriz?");
int Matriz2 = int.Parse(Console.ReadLine());

int[,] numeros = new int[Matriz, Matriz2];

double[] promedios = new double[numeros.Length];// como tomar esta opcion para promediar en double?

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

for (int i = 0; i < lengthColumnas; i++)
{
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine("Ingrese el valor de la posicion [" + i + "," + j + "]");
        numeros[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < lengthColumnas; i++)
{
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine("El valor de la posicion [" + i + "," + j + "] es: " + numeros[i, j]);
    }
}
for (int i = 0; i < lengthColumnas; i++)
{
    for (int j = 0; j < lengthFilas; j++)
    {
        j += j / lengthFilas;//promedio?
        Console.WriteLine("El promedio de la fila es : " + j);
    }
    i += i / lengthFilas;
    Console.WriteLine("El promedio de la fila es : " + i);
}
