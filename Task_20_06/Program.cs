namespace Task_20_06
{
    /*cоздайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
• Red
• Yellow
• Green
Реализуйте автоматическое переключение цветов (каждые 3 секунды).
    При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep).
    Добавьте возможность ручного переключения (например, по нажатию клавиши).
     */
    internal class Program
    {
        static TrafficLightColor currentColor = TrafficLightColor.Red;
        static void Main(string[] args)
        { 
            {
                Thread trafficLightThread = new Thread(SwitchTrafficLight);
                trafficLightThread.IsBackground = true;
                trafficLightThread.Start();

                Console.WriteLine("Нажмите 'Enter' для ручного переключения цвета или 'Esc' для выхода.");

                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Enter)
                        {
                            ManualSwitch();
                        }
                        else if (key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }

                trafficLightThread.Abort();
            }

            static void SwitchTrafficLight()
            {
                while (true)
                {
                    Thread.Sleep(3000);
                    AutomaticSwitch();
                }
            }

            static void AutomaticSwitch()
            {
                currentColor = (TrafficLightColor)(((int)currentColor + 1) % 3);
                Console.WriteLine($"Автоматическое переключение на: {currentColor}");
            }

            static void ManualSwitch()
            {
                Console.WriteLine("Ручное переключение.");
                AutomaticSwitch();
            }
        }
    }
}
