namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise04CirclePerimeter
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 4: CIRCLE PERIMETER ===");
            Console.Write("Ingrese el radio del círculo: ");

            double radio = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"Resultado: {perimetro:F2}");
        }
    }
}