using System;

namespace Project
{
    public class Menu
    {
        public static void Show(string usname)
        {
            string selection = "";
            do
            {
                Console.WriteLine
                    ($"{usname},чтобы увидеть меню нажмите ---->\"Y\" \nEсли вы знаете,что будете заказывать нажмите ---->\"N\" ");
                selection = Console.ReadLine();
                // Первести введённую строку в нижний регистр 
                selection = selection.ToLower();
                switch (selection)
                {
                    case "y":
                        Files.OpenMenu();
                        break;

                    case "n":
                        break;
                    default:
                        Console.WriteLine("Вы ввели незивестный символ");
                        break;
                }
            } while (selection != "n" & selection != "y");

        }
    }
}
