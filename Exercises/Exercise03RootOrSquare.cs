namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise03RootOrSquare
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 3: ROOT OR SQUARE ===");
            Console.Write("Ingrese un número: ");

            double numero = Convert.ToDouble(Console.ReadLine());

            double resultado;

            if (numero > 0)
            {
                resultado = Math.Sqrt(numero);
            }
            else
            {
                resultado = numero * numero;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}