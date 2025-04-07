namespace Task_24_06
{
    /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем.
     * AИспользуйтеStreamReader.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "путь_к_вашему_файлу.txt";

            try
            {
                int numberOfLines = FileHelper.CountLines(path);
                Console.WriteLine($"Количество строк в файле: {numberOfLines}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
