namespace Task_04_06
{ 
    
    internal class Program
    { /*Заполнить массив случайными положительными и отрицательными числами таким образом,
       * чтобы все числа по одулю были разными. Это значит, что в массиве не может быть
       * ни только двух равных чисел, но не может быть вух равных по модулю. В полученном
       * массиве найти наибольшее по модулю число.
       */
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int num;
                do
                {
                    num = rand.Next(-50, 51);
                } while (Array.Exists(array, x => Math.Abs(x) == Math.Abs(num)));
                array[i] = num;
            }

            int maxMod = array[0];
            foreach (var num in array)
            {
                if (Math.Abs(num) > Math.Abs(maxMod))
                    maxMod = num;
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("Наибольшее по модулю число: " + maxMod);


        }
    }
}
