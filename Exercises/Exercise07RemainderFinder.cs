namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise07RemainderFinder
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 7: REMAINDER FINDER ===");

            Console.Write("Ingrese el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
            else
            {
                int residuo = numero1 % numero2;
                Console.WriteLine($"Resultado: {residuo}");
            }
        }
    }
}