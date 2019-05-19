using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    delegate void DelShowMenu();
    public class ShowMenu
    {

       DelShowMenu menu = delegate ()
        {
            using (FileStream fstream = File.OpenRead("menu.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
            }
        };

        public void Show(string usname)
        {
            string selection = "";
            Console.WriteLine
                ($"{usname},чтобы увидеть меню нажмите ---->\"Y\" \nEсли вы знаете,что будете заказывать нажмите ---->\"N\" ");
            selection = Console.ReadLine();
            // Первести введённую строку в нижний регистр 
            selection = selection.ToLower();
            switch (selection)
            {
                case "y":
                    menu();
                    break;

                case "n":
                    break;
                default:
                    Console.WriteLine("Вы ввели незивестный символ");
                    break;
            }
        }
    }
}
