namespace Task_05_03
{
    internal class Program
    { /* Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
       * да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
       * элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.Пример:
f h h f c h
w g k m g z
a f j a o d
=>
f h h f c h
w g k m g z
a f j a o d 
       */
        static void Main(string[] args)
        {
            char[,] matrix1 =
 {
    { 'f', 'h', 'h'},
    { 'w', 'g', 'k'},
    { 'a', 'f', 'g'}
};

            char[,] matrix2 =
            {
    { 'f', 'c','h'},
    { 'm', 'g', 'z'},
    { 'a', 'o', 'd'}
};

            bool areEqual = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(matrix1[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix1[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(matrix2[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix2[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
