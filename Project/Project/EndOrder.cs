using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class EndOrder : Order
    {
        public static void End()
        {
            int result = 0;
            string order = "";
            Ord(ref order, ref result);
            Console.WriteLine($"Заказ {order} \n Cумма: {result}");

        }



    }
}
