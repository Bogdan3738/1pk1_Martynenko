namespace Task_02_04
{
    internal class Program
    { /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату)
       * произведите расчет является ли пользователь совершеннолетним
       * на текущую дату и выведите соответствующее сообщение об этом
       */
        static void Main(string[] args)
        {
            int year = Int32.Parse(Console.ReadLine());
            int month = Int32.Parse(Console.ReadLine());
            int day = Int32.Parse(Console.ReadLine());

            int years = 2025 - year;
            int months = 01 - month;
            int days = 25 - day;

            if (days < 0) months--;
            if (months < 0) years--;
            if (years >= 18)

                Console.WriteLine("Да.Ему есть 18");
            else Console.WriteLine("Нет.Ему нет 18");







        }
    }
}
