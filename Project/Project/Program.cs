using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Project
{

    class Program : IBase
    {
        public string UsName { get ; set ; }
        public string Mail { get; set ; }
       

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Добрый день вас приветсвует доставка пиццы \"Ninja Pizza\" \nКак вас зовут?");
            program.UsName = Console.ReadLine();            
            Console.WriteLine("Введите ваш mail:");
            program.Mail = Console.ReadLine();           
            ShowMenu show = new ShowMenu();
            show.Show(program.UsName);
            int result = 0;
            string order = "";
            Order.Ord(ref order,ref result);
            EndOrder.End( result,order);
            MailHandller.MesHandler (program.Mail, result);      


            Console.ReadKey();
        }
    }
}
