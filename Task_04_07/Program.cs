﻿namespace Task_04_07
{
    internal class Program
    { /*В массиве на 30 элементов содержатся данные по росту учеников в классе.
       * Рост мальчиков условно задан трицательными значениями. Вычислить и вывести количество
       * мальчиков и девочек в классе и средний рост длямальчиков и девочек.
       * При выводе избавиться от отрицательных значений.
       */
        static void Main(string[] args)
        {
            int[] heights = new int[30];
            Random rand = new Random();

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = rand.Next(-200, 201);
            }

            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] < 0)
                {
                    boysCount++;
                    boysSum += Math.Abs(heights[i]);
                }
                else
                {
                    girlsCount++;
                    girlsSum += heights[i];
                }
            }

            double avgBoys = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double avgGirls = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

        Console.WriteLine("Массив: " + string.Join(", ", heights));
            Console.WriteLine($"Количество мальчиков: {boysCount}, Средний рост мальчиков: {avgBoys}");
            Console.WriteLine($"Количество девочек: {girlsCount}, Средний рост девочек: {avgGirls}");
        }
    }
}
