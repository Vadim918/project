using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{  
  public  class Order
    {       
        public static void Change(ref string sellectionPizza, ref int cost)
        {
            string end = "";             
            while (end != "end")
            {
                int changeSection;
                Console.WriteLine("Выберете номер раздела из которого хотите заказать пиццу:");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out changeSection);
                Console.WriteLine("Какую пиццу желаете заказать?");
                sellectionPizza = sellectionPizza + "," + Console.ReadLine();               
                switch (changeSection)
                {
                    case 1:
                        cost += 16;
                        break;
                    case 2:
                        cost += 24;
                        break;
                    case 3:                        
                        cost += 32;
                        break;
                    default:
                        Console.WriteLine("Вы ввели незивестный символ");
                        break;
                }
                Console.WriteLine("Что нибудь ещё? \nДля выхода ввдеите \"end\")" );
                end = Console.ReadLine();
            }           
        }
        public static void End(int result, string order)
        {
            order = order.Substring(1);
            Console.WriteLine($"Заказ {order} \n Cумма: {result}");

        }

    }
}
