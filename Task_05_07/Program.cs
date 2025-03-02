namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив
         * целых числе [n*n]. Заполнение случайными
         * числами в диапазоне от 10 до 99 включительно.
         * Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
         * минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
         */
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(10, 100);
                }
            }

            Console.WriteLine("Исходная матрица:");
            

            int minElement = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"\nМинимальный элемент матрицы: {minElement}");

            int[,] multipliedMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    multipliedMatrix[i, j] = matrix[i, j] * minElement;
                }
            }

            Console.WriteLine("\nМатрица после умножения на минимальный элемент:");
            

            int[] flatArray = new int[n * n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    flatArray[index++] = multipliedMatrix[i, j];
                }
            }

            Array.Sort(flatArray);
            Array.Reverse(flatArray);

            int[] topFive = flatArray[..5];

            Console.WriteLine("\nМатрица с выделенными максимальными элементами:");
            
        }
    }
}
