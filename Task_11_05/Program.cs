namespace Task_11_05
{
    /*
     Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
     возвращает их сумму и произведение через выходные параметры (out).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum;
            int product;

            Calculate(ref a, ref b, out sum, out product);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }
        static void Calculate(ref int num1, ref int num2, out int sum, out int product)
        {
            // Вычисляем сумму и произведение
            sum = num1 + num2;
            product = num1 * num2;
        }
    }
}
