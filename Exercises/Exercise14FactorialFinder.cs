namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise14FactorialFinder
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 14: FACTORIAL FINDER ===");

            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
                return;
            }

            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Resultado: {factorial}");
        }
    }
}