namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise12SmallestOfFive
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 12: SMALLEST OF FIVE ===");

            double[] numeros = new double[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            double menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine($"Resultado: {menor}");
        }
    }
}