namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise06TaxCalculator
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 6: TAX CALCULATOR ===");
            Console.Write("Ingrese su salario anual: ");

            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 12000)
            {
                double excedente = salario - 12000;
                double impuesto = excedente * 0.15;

                Console.WriteLine($"Resultado: {impuesto:F2}");
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
    }
}