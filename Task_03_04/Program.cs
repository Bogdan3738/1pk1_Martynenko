namespace Task_03_04
{
    internal class Program
    { /*Пользователь вводить в консоли произвольный текст.
       * После каждого ввода консоль очищается.
       * Когда пользователь вводить слово «exit» или пустую строку
       * – ввод останавливается и выводиться количество строк введенных пользователем.
       */
        static void Main(string[] args)
        {
            int a = 0;

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "exit" || text == "") 
                break;
                Console.Clear();
                a++;


            }
            Console.WriteLine("Количество строк введенных пользователем " + a);

            
        }
    }
}
