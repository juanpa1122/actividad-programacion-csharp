namespace ActividadProgramacionCSharp.Exercises
{
    public class Exercise13VowelCounter
    {
        public void Ejecutar()
        {
            Console.WriteLine("=== EJERCICIO 13: VOWEL COUNTER ===");

            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine() ?? "";

            int contadorVocales = 0;

            foreach (char letra in palabra.ToLower())
            {
                if (letra == 'a' ||
                    letra == 'e' ||
                    letra == 'i' ||
                    letra == 'o' ||
                    letra == 'u')
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine($"Resultado: {contadorVocales}");
        }
    }
}