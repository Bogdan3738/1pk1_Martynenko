namespace Task_02_02
{
    internal class Program
    {
        // Найти значение выражения при a = 8, b = 14, с = π/4
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double step1 = Math.Pow(a-1, 1/3.0);
            double step2 = Math.Pow(b+step1, 1/4.0);

            double step3 = Math.Abs(a-b);
            double step4 = Math.Sin(c) * Math.Sin(c) + Math.Tan(c);
            double step5 = step3 * step4;

            double step6 = step2 / step5;
            Console.WriteLine(step6);





        }
    }
}
