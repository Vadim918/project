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

    class Program
    {
       
        static void Main(string[] args)
        {           
            Console.WriteLine("Добрый день вас приветсвует доставка пиццы \"Ninja Pizza \", как вас зовут?");
            Base @base = new Base();
            @base.usName = Console.ReadLine();
            ShowMenu show = new ShowMenu();
            show.Show(@base.usName);
            EndOrder.End();




            


            Console.ReadKey();
        }
    }
}
