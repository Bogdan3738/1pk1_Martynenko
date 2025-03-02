namespace Task_10_7
{
    /*Создайте метод с помощью которого можно
     * сгенерировать и вернуть символьный двумерныймассив
     * (состоящий из символов русского алфавита)
     * и выведите на консоль данный массив с помощью другого метода
     * (который принимает данный массив в качестве параметра)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintChar(Alphabet(8));
        }
        static char[,] Alphabet(int n)
        {
            char[,] arr = new char[n,n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (char)rnd.Next((int)'а', (int)'я' + 1);

                }
            }
            return arr;
        
        }
        static void PrintChar(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }    
                  
        }
    }
}
