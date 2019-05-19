using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class EndOrder : Order
    {
        public static void End(int result,string order)
        { 
            order = order.Substring(1);
            Console.WriteLine($"Заказ {order} \n Cумма: {result}");           
        }
    }
}
