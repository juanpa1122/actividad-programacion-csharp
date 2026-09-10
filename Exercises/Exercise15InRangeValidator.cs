namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise15InRangeValidator
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 15: INRANGE VALIDATOR ===");

            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Resultado: Está en el rango.");
            }
            else
            {
                Console.WriteLine("Resultado: Fuera del rango.");
            }
        }
    }
}