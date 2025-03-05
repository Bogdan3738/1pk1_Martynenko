namespace Task_11_07
{
    /*
     Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
оригинальный массив вне метода.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Массив до изменения:");
            PrintArray(originalArray);

            
            IncreaseArrayElements(originalArray);

            Console.WriteLine("Массив после изменения:");
            PrintArray(originalArray);
        }
        static void IncreaseArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
