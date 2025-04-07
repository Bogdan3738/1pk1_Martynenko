using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class InternetShop
    {
        static Dictionary<OrderStatus, string> nameStatus = new Dictionary<OrderStatus, string>()
        {
            {OrderStatus.New,"Новый" },
            {OrderStatus.Processing,"В обработке" },
            {OrderStatus.Shipped,"Отправлен" },
            {OrderStatus.Delivered, "Доставлен"},
            {OrderStatus.Cancelled,"Отменен" }

        };
       public OrderStatus orderStatus = OrderStatus.New;

        public  void SetStatus(OrderStatus status)
        {
            if (orderStatus != OrderStatus.Cancelled && orderStatus != OrderStatus.Delivered) 
            {
                Console.WriteLine($"Заказ приведен в статус:{nameStatus[status]}");
         orderStatus=status;
            } 
           
        }

                                                   
       
    }
}
