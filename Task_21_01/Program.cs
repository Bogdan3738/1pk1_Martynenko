namespace Task_21_01
{ /*Дан список чисел.
   * Создать новый список, содержащий только чётные числа из исходного списка, умноженныена 10.
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Исходный список чисел
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Новый список, содержащий чётные числа, умноженные на 10
            List<int> evenNumbersMultipliedBy10 = numbers
                .Where(n => n % 2 == 0) // Фильтр на чётные числа
                .Select(n => n * 10)    // Умножаем каждое чётное число на 10
                .ToList();              // Преобразуем в список

            // Вывод результата
            Console.WriteLine("Чётные числа, умноженные на 10:");
            foreach (var number in evenNumbersMultipliedBy10)
            {
                Console.WriteLine(number);
            }
        }
    }
}
