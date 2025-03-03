namespace Task_11_01
{
    /*
     Передача по значению: Напишите метод, который принимает два целых числа
    и меняет их местами. Проверьте, изменились ли значения переменных вне метода
     */
    

    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До изменения: a = {a}, b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"После изменения: a = {a}, b = {b}");
        }

        static void Swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }


}
