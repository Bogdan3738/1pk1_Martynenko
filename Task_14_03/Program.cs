namespace Task_14_03
{
    /*
     Реализуйте статический метод Factorial, который принимает целое число
    и возвращает его факториал. Сделайте так, чтобы метод работал только для неотрицательных чисел.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Factorial(5));

        }
        static int Factorial(int x)
        {
            int y = 1;
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }

            return y;


        }   
    }
}
