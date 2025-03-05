namespace Task_11_08
{
    /*
     Использование params и out: Напишите метод, который принимает переменное количество
     чисел и возвращает их сумму и максимальное значение через выходные параметры (out).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, max;
            CalculateSumAndMax(out sum, out max, 1,  2 , 3, 4, 5);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Максимальное значение: {max}");
        }

        static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue; // Инициализируем минимальным возможным значением

            foreach (var number in numbers)
            {
                sum += number; // Суммируем числа
                if (number > max)
                {
                    max = number; // Находим максимальное значение
                }
            }

            // Обработка случая, когда массив пуст
            if (numbers.Length == 0)
            {
                max = 0; // Можно установить любое значение, например, 0 или выбросить исключение
            }

        }
    }
}
