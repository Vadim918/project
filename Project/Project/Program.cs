using System;

namespace Project
{
    class Program 
    {  
        static void Main(string[] args)
        {
            Base user = new Base();
            Console.WriteLine("Добрый день вас приветсвует доставка пиццы \"Ninja Pizza\" \nКак вас зовут?");
            user.UserName = Console.ReadLine();            
            Console.WriteLine("Введите ваш mail:");
            user.Mail = Console.ReadLine();
            Menu.Show(user.UserName);      
           

            int result = 0;
            string order = "";
            Order.Change(ref order,ref result);

            Order.End(result,order);
           MailHandller.MesHandler (user.Mail, result);  
            

            Console.ReadKey();
        }
    }
}
