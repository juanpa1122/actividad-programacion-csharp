namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise08SumOfEvens
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 8: SUM OF EVENS ===");

            int suma = 0;

            for (int numero = 1; numero <= 50; numero++)
            {
                if (numero % 2 == 0)
                {
                    suma += numero;
                }
            }

            Console.WriteLine($"Resultado: {suma}");
        }
    }
}