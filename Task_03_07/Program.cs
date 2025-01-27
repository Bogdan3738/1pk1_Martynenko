namespace Task_03_07
{
    internal class Program
    { /*Написать программу, которая выводит таблицу скорости
       * (через каждые 0,5с) свободно падающего тела
       * v = g t , где 2 g = 9,8 м/с2 – ускорение свободного падения.
       */
        static void Main(string[] args)
        {
            double t = 0.5;
            for (t = 0.5; t <= 10; t++)
            {
                double g = 9.8 / 2;
                double v = g * t;
                Console.WriteLine( "Таблица скорости(через каждые 0.5с)"+v);
            }
            

          
        }
    }
}
