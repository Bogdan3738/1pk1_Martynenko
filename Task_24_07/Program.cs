namespace Task_24_07
{
    /*Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки,
     * содержащие это слово (регистронезависимо).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string filePath = "example.txt"; // Замените на путь к вашему файлу
                string searchWord = "ваше_слово"; // Замените на слово для поиска

                List<string> result = FindLinesContainingWord(filePath, searchWord);

                foreach (var line in result)
                {
                    Console.WriteLine(line);
                }
            }

            static List<string> FindLinesContainingWord(string filePath, string word)
            {
                List<string> linesWithWord = new List<string>();

                try
                {
                    // Чтение всех строк из файла
                    string[] allLines = File.ReadAllLines(filePath);

                    foreach (string line in allLines)
                    {
                        // Проверка на наличие слова (игнорируя регистр)
                        if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            linesWithWord.Add(line);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Ошибка чтения файла: {e.Message}");
                }

                return linesWithWord;
            }
        }
    }
}
