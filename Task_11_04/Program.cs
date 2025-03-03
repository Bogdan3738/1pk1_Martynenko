namespace Task_11_04
{
    /*
     Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
     их среднее значение. Используйте ключевое слово params
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double average = Method(1, 3, 6, 9, 12);
            Console.WriteLine("Среднее значение: " + average);
        }
        static double Method(params double[] numbers) 
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив чисел не должен быть пустым.");
            }

            double sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}
