namespace Task_20_03
{
    /*Создайте программу для управления статусом заказа в интернет-магазине.
     * Используйте перечисление OrderStatus со значениями:
• New (новый)
• Processing (в обработке)
• Shipped (отправлен)
• Delivered (доставлен)
• Cancelled (отменён)
Напишите метод, который меняет статус заказа. Если заказ уже доставлен или отменён,
    запретите изменение статуса. Выводите сообщение при каждом изменении статуса (например,
"Заказ переведён в статус: Отправлен").
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            InternetShop sinka =new InternetShop();

            Console.WriteLine(sinka.orderStatus);
            
            sinka.SetStatus(OrderStatus.New);
            sinka.SetStatus(OrderStatus.Shipped);
            sinka.SetStatus(OrderStatus.Cancelled);
            sinka.SetStatus(OrderStatus.Delivered);
        }
    }
}
