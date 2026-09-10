namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise11AverageOfFour
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 11: AVERAGE OF FOUR ===");

            Console.Write("Ingrese el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double numero4 = Convert.ToDouble(Console.ReadLine());

            double promedio = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine($"Resultado: {promedio}");
        }
    }
}