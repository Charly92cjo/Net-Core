string continuar = "S";
do
{
    Console.Clear();
    Console.WriteLine("Hola Polo Tecnológico Minaclavero!");
    Console.WriteLine("Bienvenidos a mi codigo");
    Console.WriteLine("Cuál es tu nombre?\n");


    string tu_nombre = "";
    tu_nombre = Console.ReadLine();//Eugenio, Ruben, Ezequiel, Carlos, Joaquin
    while (tu_nombre != null)
    {
        if (tu_nombre != "")
        {
            Console.WriteLine($"Hola {tu_nombre.ToUpper()}, que hacés cabeza!\n");
            break;
        }
        else
        {
            Console.WriteLine("No me engañes, tenés que escribir tu nombre");
            tu_nombre = Console.ReadLine();
        }
    }

    Console.WriteLine("Todo bien?\n");
    string? pregunta;
    pregunta = Console.ReadLine();
    while (pregunta != null)
    {
        if (pregunta.ToUpper() == "BIEN")
        {
            Console.WriteLine("Me alegro que andes bien, sigue así! :-D\n");
            break;
        }
        else if (pregunta.ToUpper() == "MAL")
        {
            Console.WriteLine("Uy que mal, espero que te mejores y recuerda");
            Console.WriteLine("'Al mal tiempo buena cara'\n");
            break;
        }
        else if (pregunta.ToUpper() == "MASO")
        {
            Console.WriteLine("Ni en pedo creo que elijas esta opción pero aca está");
            Console.WriteLine("Mantén la mente positiva y las cosas mejorarán\n");
            break;
        }
        else if (pregunta == "")
        {
            Console.WriteLine("Creo que debiste escribir algo");
            pregunta = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Soy un programa básico, no tengo tantas opciones de respuestas, era poner bien o mal, que esperabas? :-P\n");
            break;
        }
    }
    Console.WriteLine("¿Desea continuar en mi código? 'S' decir Si o 'N' decir No\n");
    continuar = Console.ReadLine();
    if (continuar.ToUpper() == "N")
        Console.WriteLine("Programa finalizado correctamente, gracias por ver mi código" + tu_nombre + "que tengas un buen día");
    else if (continuar.ToUpper() != "S")
    {
        Console.WriteLine($"Opción no válida, creo que le estas errando {tu_nombre.ToUpper()}");
        Console.WriteLine("Intenta con 'S' o 'N'");
        continuar = Console.ReadLine();
        Console.WriteLine("Programa finalizado incorrectamente, no era tan difícil pulsar una 'S' o 'N', creo que no entendiste");

    }
}
while (continuar.ToUpper() == "S");