//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

int[] numeros = new int[10];
Console.WriteLine($"Por favor ingrese: {numeros.Length} números ");


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
Console.WriteLine($"valor de suma = {suma}\n");


int max = numeros[0];
int min = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > max)
        max = numeros[i];
    else if (numeros[i] < min)
        min = numeros[i];
}

Console.WriteLine("\nLa número mayor es: " + max);
Console.WriteLine("\nLa número menor es: " + min);


int promedio=0;
for (int i = 0; i < numeros.Length; i++)
{
    promedio = suma / numeros.Length;
}
Console.WriteLine("\nEl promedio es: " + promedio);


;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"\nLos números ingresados en pantalla son: {numeros[i]}");
}

//Me que costó hacerlo ya que no hemos visto algunas cosas y tuve que ver algunos foros para poder terminarlo




