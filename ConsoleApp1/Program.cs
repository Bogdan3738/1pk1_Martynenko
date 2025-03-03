using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"До изменения: a = {a}, b = {b}");

        Swap(ref a, ref b); // передаем переменные по ссылке

        Console.WriteLine($"После изменения: a = {a}, b = {b}");
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
