using System;
using System.Linq;

public class PalindromeB
{
    public static bool EsPalindromo(string text)
    {
    
        string cleanedText = new string(text.ToLower().Where(char.IsLetterOrDigit).ToArray());

        // Comparar invertida
        return cleanedText == new string(cleanedText.Reverse().ToArray());
    }

    public static int CountVowels(string text)
    {
        // Definir vocales y contar las ocurrencias en el texto
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return text.ToLower().Count(c => vowels.Contains(c));
    }

        public static void Main()
    {
        // agregar aqui el texto a verificar
        string[] phrases = { "radar" };

        foreach (string phrase in phrases)
        {
            if (EsPalindromo(phrase))
            {
                Console.WriteLine($"{phrase} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"{phrase} no es un palíndromo.");
            }

            int vowelCount = CountVowels(phrase);
            Console.WriteLine($"La frase '{phrase}' tiene {vowelCount} vocales.\n");
        }
    }
}