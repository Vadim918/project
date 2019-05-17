using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    

    class Order
    {
        public static void Ord (ref string sellectionPizza, ref int count)
        {
            string end = "";             
            while (end != "end")
            {
                Console.WriteLine("Выберете номер раздела из которого хотите заказать пиццу:");
                // Исключение (ввод буквы)
                int changeSection = Convert.ToInt32(Console.ReadLine());
                switch (changeSection)
                {
                    case 1:
                        Console.WriteLine("Какую пиццу желаете заказать?");
                        sellectionPizza = sellectionPizza + "," + Console.ReadLine();
                        count = count + 16;
                        break;
                    case 2:
                        Console.WriteLine("Какую пиццу желаете заказать?");
                        sellectionPizza = sellectionPizza + "," + Console.ReadLine();
                        count = count + 22;
                        break;
                    case 3:
                        Console.WriteLine("Какую пиццу желаете заказать?");
                        sellectionPizza = sellectionPizza + "," + Console.ReadLine();
                        count = count + 32;
                        break;
                    default:
                        Console.WriteLine("Вы ввели незивестный символ");
                        break;
                }
                Console.WriteLine("Что нибудь ещё? \n Для выхода ввдеите \"end\")");
                end = Console.ReadLine();
            }

            
        }
        






    }
}
