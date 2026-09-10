namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise02DoubleOrTriple
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 2: DOUBLE OR TRIPLE ===");

            Console.Write("Ingrese el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado;

            if (numero1 >= numero2)
            {
                resultado = numero1 * 2;
            }
            else
            {
                resultado = numero2 * 3;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}