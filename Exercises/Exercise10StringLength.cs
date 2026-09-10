namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise10StringLength
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 10: STRING LENGTH ===");

            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine() ?? "";

            int longitud = palabra.Length;

            Console.WriteLine($"Resultado: {longitud}");
        }
    }
}