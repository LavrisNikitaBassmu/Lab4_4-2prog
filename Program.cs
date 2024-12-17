using System;

class Program
{
    static void Main()
    {
        const int numberOfLines = 7;
        string[] lines = new string[numberOfLines];

        // Ввод строк
        for (int i = 0; i < numberOfLines; i++)
        {
            Console.WriteLine($"Введите строку {i + 1}:");
            lines[i] = Console.ReadLine();
        }

        // Переменные для поиска строки с наименьшим числом пробелов
        int minSpacesCount = int.MaxValue;
        int lineWithMinSpaces = -1;

        Console.WriteLine("\nСтроки, содержащие слова, оканчивающиеся на '.com':");

        for (int i = 0; i < numberOfLines; i++)
        {
            string currentLine = lines[i];
            string[] words = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int spacesCount = currentLine.Length - currentLine.Replace(" ", "").Length;
            bool hasComWord = false;

            // Проверяем слова на окончание ".com"
            foreach (var word in words)
            {
                if (word.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
                {
                    hasComWord = true;
                    break;
                }
            }

            // Вывод строки, если содержит слово на ".com"
            if (hasComWord)
            {
                Console.WriteLine(currentLine);
            }

            // Проверка наименьшего числа пробелов
            if (spacesCount < minSpacesCount)
            {
                minSpacesCount = spacesCount;
                lineWithMinSpaces = i + 1; // Номер строки (1-индексация)
            }
        }

        // Вывод номера строки с наименьшим числом пробелов
        Console.WriteLine($"\nНомер строки с наименьшим числом пробелов: {lineWithMinSpaces}");
    }
}