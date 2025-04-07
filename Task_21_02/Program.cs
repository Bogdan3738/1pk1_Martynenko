namespace Task_21_02
{
    /*Дан текст. Написать метод,
     * который возвращает словарь, где ключ — слово,
     * а значение —количествоеговхождений в тексте
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это тестовый текст. Тестовый текст содержит слова. Слова повторяются.";
            var wordCount = CountWords(text);

            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"Слово: {kvp.Key}, Количество: {kvp.Value}");
            }
        }

        static Dictionary<string, int> CountWords(string text)
        {
            // Приводим текст к нижнему регистру и разбиваем на слова
            var words = text.ToLower()
                            .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' },
                                   StringSplitOptions.RemoveEmptyEntries);

            // Создаем словарь для подсчета
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                // Если слово уже есть в словаре, увеличиваем счетчик, иначе добавляем его в словарь
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}
