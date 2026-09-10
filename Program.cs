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
    Console.WriteLine("6. Tax Calculator");
    Console.WriteLine("7. Remainder Finder");
    Console.WriteLine("8. Sum of Evens");
    Console.WriteLine("9. Fraction Difference");
    Console.WriteLine("10. String Length");
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

        case "6":
            new Exercise06TaxCalculator().Ejecutar();
            break;

        case "7":
            new Exercise07RemainderFinder().Ejecutar();
            break;

        case "8":
            new Exercise08SumOfEvens().Ejecutar();
            break;

        case "9":
            new Exercise09FractionDifference().Ejecutar();
            break;

        case "10":
            new Exercise10StringLength().Ejecutar();
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