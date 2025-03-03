namespace Task_11_02
{
    /*
     Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
       меняет их местами. Проверьте, изменились ли значения переменных вне метода
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Console.WriteLine($"до изменений a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"после изменений a={a},b={b}");

        }
        static void Swap(ref int i , ref int j)
        {
            int temp=i; i=j; j=temp;
        }
    }
}
