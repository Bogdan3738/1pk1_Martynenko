namespace Task_10_08
{
    /*Создайте метод, который на вход принимает одномерный массив и число для поиска,
     * верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1
     */
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] array = {-3,4,5,0,8,3,90,10,200};
            Console.WriteLine(GetIndex(array,200));
        }
        static int GetIndex(int[] ind, int n)
        { 
        for(int i = 0; i < ind.GetLength(0); i++)
            {
                if(ind[i] == n) return i;
                
            }
        return -1;
            
        }
    }
}
