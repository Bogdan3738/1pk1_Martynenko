namespace Task_11_06
{
    /*
     Передача массива по значению: Напишите метод, который принимает массив целых чисел и
изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
массив вне метода.
     */
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Оригинальный массив до вызова метода: " + string.Join(", ", originalArray));

            // Вызов метода, изменяющего массив
            IncreaseArrayElements(originalArray);

            Console.WriteLine("Оригинальный массив после вызова метода: " + string.Join(", ", originalArray));
        }
        static void IncreaseArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1; 
            }
        }
    }
}
