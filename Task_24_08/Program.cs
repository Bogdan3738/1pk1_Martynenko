namespace Task_24_08
{
    /*реализуйте функцию, осуществляющую поиск текста в файле
     * и его замену на значения, введенныепользователем
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            // Проверка существования файла
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Ошибка: Указанный файл не существует.");
                return;
            }

            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            try
            {
                // Чтение содержимого файла
                string fileContent = File.ReadAllText(filePath);

                // Замена текста
                string updatedContent = fileContent.Replace(searchText, replaceText);

                // Запись обновленного содержимого обратно в файл
                File.WriteAllText(filePath, updatedContent);

                Console.WriteLine("Замена выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
    
}
