namespace Task_04_10
{
    internal class Program
    { /*Заполнить массив из 10 элементов случайными числами в интервале [-10..10]
       * и сделать реверс элементовотдельно для 1-ой и 2-ой половин массива. 
       * Реверс реализовать через цикл. Стандартные методы класса Array спользовать нельзя.
       * Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
       * Результат: [4,0,-10,2,5,-7,9,2,7,-6]
       */
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            ReverseArray(array, 0, array.Length / 2 - 1);

            ReverseArray(array, array.Length / 2, array.Length - 1);

            Console.WriteLine("Результат: " + string.Join(", ", array));

            void ReverseArray(int[] array, int start, int end)
            {
                while (start < end)
                {
                    int temp = array[start];
                    array[start] = array[end];
                    array[end] = temp;

                    start++;
                    end--;
                }
            }
        }
    }
}
