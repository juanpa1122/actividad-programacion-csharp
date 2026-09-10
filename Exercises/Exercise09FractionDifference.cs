namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise09FractionDifference
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 9: FRACTION DIFFERENCE ===");

            Console.Write("Ingrese el numerador de la primera fracción: ");
            int numerador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el denominador de la primera fracción: ");
            int denominador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el numerador de la segunda fracción: ");
            int numerador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el denominador de la segunda fracción: ");
            int denominador2 = Convert.ToInt32(Console.ReadLine());

            if (denominador1 == 0 || denominador2 == 0)
            {
                Console.WriteLine("Error: el denominador no puede ser cero.");
                return;
            }

            int numeradorResultado =
                (numerador1 * denominador2) -
                (numerador2 * denominador1);

            int denominadorResultado =
                denominador1 * denominador2;

            if (numeradorResultado == 0)
            {
                Console.WriteLine("Resultado: 0");
                return;
            }

            int divisor = CalcularMCD(
                Math.Abs(numeradorResultado),
                Math.Abs(denominadorResultado)
            );

            numeradorResultado /= divisor;
            denominadorResultado /= divisor;

            if (denominadorResultado < 0)
            {
                numeradorResultado *= -1;
                denominadorResultado *= -1;
            }

            Console.WriteLine(
                $"Resultado: {numeradorResultado}/{denominadorResultado}"
            );
        }

        private int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temporal = b;
                b = a % b;
                a = temporal;
            }

            return a;
        }
    }
}