namespace Task_05_05
{
    internal class Program

    { /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив
       * целых числе [n*m]. Заполнение
       * случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
       * по следующему правилу:
•
        Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры массива: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] matrix = new int[n, m];

            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-99, 100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Преобразованная матрица: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(-matrix[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (matrix[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
