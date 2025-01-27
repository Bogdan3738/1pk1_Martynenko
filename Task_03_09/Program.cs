namespace Task_03_09 { 

//Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
//отбрасывается.Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
//менее y рублей.

    class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму вклада (x): ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент увеличения (p): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите целевую сумму (y): ");
            double y = Convert.ToDouble(Console.ReadLine());

            int years = 0;

            while (x < y)
            {
                x += x * (p / 100);

                x = Math.Floor(x * 100) / 100;

                years++;
            }

            Console.WriteLine($"Вклад достигнет не менее {y} рублей через {years} лет.");
        }
    }
}
















    

