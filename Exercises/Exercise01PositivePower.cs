namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise01PositivePower
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 1: POSITIVE POWER ===");
            Console.Write("Ingrese un número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                int resultado = numero * numero;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Número negativo.");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
    }
}