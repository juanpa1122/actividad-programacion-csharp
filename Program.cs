using ActividadProgramacionCSharp.Exercises;

bool salir = false;

while (!salir)
{
    Console.Clear();

    Console.WriteLine("======================================");
    Console.WriteLine("   ACTIVIDAD PROGRAMACIÓN C# - .NET");
    Console.WriteLine("======================================");
    Console.WriteLine();
    Console.WriteLine("1. Positive Power");
    Console.WriteLine("2. Double or Triple");
    Console.WriteLine("3. Root or Square");
    Console.WriteLine("4. Circle Perimeter");
    Console.WriteLine("5. Midweek Day");
    Console.WriteLine("0. Salir");
    Console.WriteLine();

    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine() ?? "";

    Console.Clear();

    switch (opcion)
    {
        case "1":
            new Exercise01PositivePower().Ejecutar();
            break;

        case "2":
            new Exercise02DoubleOrTriple().Ejecutar();
            break;

        case "3":
            new Exercise03RootOrSquare().Ejecutar();
            break;

        case "4":
            new Exercise04CirclePerimeter().Ejecutar();
            break;

        case "5":
            new Exercise05MidweekDay().Ejecutar();
            break;

        case "0":
            salir = true;
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine();
        Console.WriteLine("Presione una tecla para volver al menú...");
        Console.ReadKey();
    }
}